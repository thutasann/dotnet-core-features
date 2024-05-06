namespace BlazorTicTacToeShared
{
    /// <summary>
    /// Tic Tac Toe Game Entitiy
    /// </summary>
    public class TicTacToeGame
    {
        public string? PlayerXId { get; set; }
        public string? PlayerOId { get; set; }
        public string? CurrentPlayerId { get; set; }
        public string CurrentPlayerSymbol => CurrentPlayerId == PlayerXId ? "X" : "O";
        public bool GameStarted { get; set; } = false;
        public bool GameOver { get; set; } = false;
        public bool IsDraw { get; set; } = false;
        public string Winner { get; set; } = string.Empty;
        public List<List<string>> Board { get; set; } = new(3);

        public TicTacToeGame()
        {
            InitializeBoard();
        }

        /// <summary>
        /// Start Game Method
        /// </summary>
        public void StartGame()
        {
            CurrentPlayerId = PlayerXId;
            GameStarted = true;
            GameOver = false;
            Winner = string.Empty;
            IsDraw = false;
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            Board.Clear();
            for (int i = 0; i < 3; i++)
            {
                var row = new List<string>();
                for (int j = 0; j < 3; j++)
                {
                    row.Add(string.Empty);
                }
                Board.Add(row);
            }
        }
    }
}