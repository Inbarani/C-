using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class DiceGame : Form
    {
        private int currentPlayer = 1; // To track the current player (1 or 2)
        private int player1Score = 0;
        private int player2Score = 0;
        private int player1RoundScore = 0;
        private int player2RoundScore = 0;
        private int consecutiveNonOneRolls = 0;
        private bool gameInProgress = false;
        private Timer autoRollTimer = new Timer();
        private bool autoRolling = false;
        private bool gamePaused = false;
        //private Random random = new Random();

        public DiceGame()
        {
            InitializeComponent();
            btnHeittaNoppa.Enabled = false;
            comboBoxGameOptions.Enabled = true;
            comboBoxGameOptions2.Enabled = true;

            // Set up the timer for automatic rolls
            autoRollTimer.Interval = 3000;
            autoRollTimer.Tick += AutoRollTimer_Tick;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeGameOptions();

        }

        private void btnUusiPeli_Click(object sender, EventArgs e)
        {
            // Enable the ComboBox
            comboBoxGameOptions.Enabled = true;
            comboBoxGameOptions2.Enabled = true;
            // Ask the player to choose an option
            string selectedOption1 = comboBoxGameOptions.SelectedItem.ToString();
            string selectedOption2 = comboBoxGameOptions2.SelectedItem.ToString();

            // Combine the selected options for player1 and player2
            string selectedOptions = $"{selectedOption1} vs {selectedOption2}";

            string gameMode = string.Empty;
            if (string.IsNullOrEmpty(selectedOptions))
            {
                // Clear the TextBox when no option is selected
                txtPelaajaTieto.Clear();
            }
            else
            {
                // Display the selected option in the TextBox
                txtPelaajaTieto.Text = selectedOptions;
            }


            // Reset the game to start a new one
            ResetGame();
            gameInProgress = true; // Start the game
            btnHeittaNoppa.Enabled = true; // Enable the btnHeittaNoppa button
            player1Score = 0;
            player2Score = 0;
            txtPelaaja1Piste.Text = "0";
            txtPelaaja2Piste.Text = "0";
            currentPlayer = 1;



        }

        private void btnHeittaNoppa_Click(object sender, EventArgs e)
        {
            string selectedOption1 = comboBoxGameOptions.SelectedItem.ToString();
            string selectedOption2 = comboBoxGameOptions2.SelectedItem.ToString();

            if ((selectedOption1 == "Kone1" && selectedOption2 == "Kone2") || (selectedOption1 == "Kone2" && selectedOption2 == "Kone1"))
            {
                // Both players are machines, enable auto-rolling
                autoRolling = true;
                autoRollTimer.Start();
                RollDice();
                return;
            }

            Random random = new Random();
            int diceValue = random.Next(1, 7); // Roll a six-sided die                      

            if (diceValue != 1) // Check if the dice value is not 1
            {
                if (currentPlayer == 1)
                {
                    player1Score += diceValue;
                    txtPelaaja1Piste.Text = player1Score.ToString();
                }
                else
                {
                    player2Score += diceValue;
                    txtPelaaja2Piste.Text = player2Score.ToString();
                }

            }

            // Update the UI with the dice value
            MessageBox.Show("Player " + currentPlayer + " rolled a " + diceValue);

            // Check if the dice shows 1
            if (diceValue == 1)
            {
                if (currentPlayer == 1)
                {
                    currentPlayer = 2;
                }
                consecutiveNonOneRolls = 0;
            }
            else
            {
                consecutiveNonOneRolls++;
                // Update the score for the current player
                if (currentPlayer == 1)
                {
                    player1Score += diceValue;
                    txtPelaaja1Piste.Text = player1Score.ToString();
                }
                else
                {
                    player2Score += diceValue;
                    txtPelaaja2Piste.Text = player2Score.ToString();
                }

                if (consecutiveNonOneRolls % 3 == 0)
                {
                    var result = MessageBox.Show("Player " + currentPlayer + ", Haluatko jatkaa?", "Jatka vuoro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                    {
                        currentPlayer = (currentPlayer == 1) ? 2 : 1;
                        consecutiveNonOneRolls = 0;
                    }
                }

                if ((player1Score >= 25 || player2Score >= 25) && (selectedOption1 == "Kone1" || selectedOption2 == "Kone2"))
                {
                    if (player1Score >= 25)
                    {
                        MessageBox.Show("Player 1 wins!");
                        ResetGame();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Player 2 wins!");
                        ResetGame();
                        return;
                    }

                }

                SaveGameState();
            }
        }


        private void btnJatkaPeli_Click(object sender, EventArgs e)
        {
            string savedGameStateFile = "savedGame.txt";
            btnHeittaNoppa.Enabled = true;
            // Check if the game is paused and saved state exists
            if (File.Exists(savedGameStateFile))
            {
                // Reset game scores and state
                ResetGame();

                using (StreamReader reader = new StreamReader(savedGameStateFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(',');

                        if (values.Length == 6)
                        {
                            // Code for interpreting and resuming the game state, as previously explained
                            // Extract and process the saved values to resume the game state

                            player1Score = int.Parse(values[3].Trim()); // Load Player 1 score
                            player2Score = int.Parse(values[4].Trim()); // Load Player 2 score
                            currentPlayer = int.Parse(values[2].Trim()); // Load the current player

                            // Update the UI to reflect the loaded game state
                            txtPelaaja1Piste.Text = player1Score.ToString();
                            txtPelaaja2Piste.Text = player2Score.ToString();

                            MessageBox.Show("Game state loaded. Player " + currentPlayer + ", your turn!");
                        }
                        else
                        {
                            MessageBox.Show("Invalid format in the saved game state.");
                            return; // Exit the loop if the format is incorrect
                        }
                    }
                }

                // Once the game state is fully resumed, set the gameInProgress flag to true
                gameInProgress = true;
                btnHeittaNoppa.Enabled = true; // Enable rolling the dice
            }
            else
            {
                MessageBox.Show("No saved game state found.");
            }

        }




        private void SaveGameState()
        {
            // Get the current date and time
            DateTime currentDate = DateTime.Now;

            // Create a formatted date string (you can adjust the format as needed)
            string dateString = currentDate.ToString("yyyy-MM-dd HH:mm:ss");

            // Create the game state string including player scores and selected combo box item
            string gameState = $"{dateString}, {comboBoxGameOptions.SelectedItem}, Pelaaja{currentPlayer} vuoro, Pelaaja1 pisteet: {player1Score}, Pelaaja2 pisteet: {player2Score}";

            // Save the current game state to a file
            using (StreamWriter writer = new StreamWriter("savedGame.txt", true)) // Append mode
            {
                writer.WriteLine(gameState);
            }
        }
        private void DiceGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save the game state when the form is closed
            SaveGameState();
        }
        private void ResetGame()
        {
            player1Score = 0;
            player2Score = 0;
            player1RoundScore = 0;
            player2RoundScore = 0;
            currentPlayer = 1;
            txtPelaaja1Piste.Text = "0";
            txtPelaaja2Piste.Text = "0";
            gameInProgress = false; // End the game
            btnHeittaNoppa.Enabled = false; // Disable the btnHeittaNoppa button
        }
        private void InitializeGameOptions()
        {
            // Add game options to the ComboBox
            comboBoxGameOptions.Items.Add("Inba");
            comboBoxGameOptions.Items.Add("Kone1");
            comboBoxGameOptions2.Items.Add("Kaveri");
            comboBoxGameOptions2.Items.Add("Kone2");

            // Set the default selection
            comboBoxGameOptions.SelectedIndex = 0;
            comboBoxGameOptions2.SelectedIndex = 0;
        }
        private void RollDice()
        {
            Random random = new Random();
            int diceValue = random.Next(1, 7); // Roll a six-sided die

            // Update the UI with the dice value
            MessageBox.Show("Player " + currentPlayer + " rolled a " + diceValue);

            // Check if the dice shows 1
            if (diceValue == 1)
            {
                // If it's player 1's turn, end their turn and switch to player 2
                if (currentPlayer == 1)
                {
                    currentPlayer = 2;
                }
                consecutiveNonOneRolls = 0;
            }
            else
            {
                consecutiveNonOneRolls++;
                // Update the score for the current player
                if (currentPlayer == 1)
                {
                    player1Score += diceValue;
                    txtPelaaja1Piste.Text = player1Score.ToString();
                }
                else
                {
                    player2Score += diceValue;
                    txtPelaaja2Piste.Text = player2Score.ToString();
                }

                if (consecutiveNonOneRolls % 3 == 0)
                {
                    var result = MessageBox.Show("Player " + currentPlayer + ", Haluatko jatkaa?", "Jatka vuoro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                    {
                        // Switch to the next player
                        currentPlayer = (currentPlayer == 1) ? 2 : 1;
                        consecutiveNonOneRolls = 0;
                    }
                }

                if (player1Score >= 25 || player2Score >= 25)
                {
                    // Game over, determine the winner
                    if (player1Score >= 25)
                    {
                        MessageBox.Show("Player 1 wins!");
                    }
                    else
                    {
                        MessageBox.Show("Player 2 wins!");
                    }
                    if (comboBoxGameOptions.SelectedItem.ToString() == "Kone1" && comboBoxGameOptions2.SelectedItem.ToString() == "Kone2")
                    {
                        // Automatically roll the dice for "Kone1" and "Kone2" after a delay
                        autoRolling = true;
                        autoRollTimer.Start();
                        RollDice(); // Roll the dice continuously for "Kone1" and "Kone2"
                    }

                    ResetGame();
                }

                // Call the SaveGameState method to save the game state after each turn
                SaveGameState();
            }
        }

        private void comboBoxGameOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption1 = comboBoxGameOptions.SelectedItem.ToString();
            string selectedOption2 = comboBoxGameOptions2.SelectedItem.ToString();

            if (selectedOption1 == "Kone1" || selectedOption2 == "Kone2")
            {
                // Start automatic rolls for "Kone1" and "Kone2"
                autoRolling = true;

            }
            else
            {
                // Require manual rolls for "Inba" and "Kaveri"
                autoRolling = false;

            }
        }

        private void AutoRollTimer_Tick(object sender, EventArgs e)
        {
            // Automatically roll the dice if it's a "Kone1" or "Kone2" turn
            if (autoRolling)
            {
                btnHeittaNoppa_Click(this, EventArgs.Empty);
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void ResumeGame()
        {
            gamePaused = false;
            btnHeittaNoppa.Enabled = true;
            if (currentPlayer == 1)
            {
                txtPelaaja1Piste.Text = player1Score.ToString();
                txtPelaaja2Piste.Text = player2Score.ToString();
                MessageBox.Show("Player 1, your turn!"); // Display the current player's turn
            }
            else
            {
                txtPelaaja1Piste.Text = player1Score.ToString();
                txtPelaaja2Piste.Text = player2Score.ToString();
                MessageBox.Show("Player 2, your turn!"); // Display the current player's turn
            }

        }

        private void pausebtn_Click(object sender, EventArgs e)
        {
            string selectedOption1 = comboBoxGameOptions.SelectedItem.ToString();
            string selectedOption2 = comboBoxGameOptions2.SelectedItem.ToString();

            // Save the game state in the 'savedGame.txt' file
            SaveGameState();
            // Disable the button that triggers automatic dice rolling to simulate the pause
            btnHeittaNoppa.Enabled = false;

        }
    }
}