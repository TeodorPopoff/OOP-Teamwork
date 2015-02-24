using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TheQuest
{
    public class GameEngine
    {
        private const int BattlefieldWidth = 1;
        private const int BattlefieldHeight = 1;
        private const int MaxNumberOfCharacters = 1;
        private ICollection<GameObject> allObjects;
        private KeyListener userInterface;
        private ConsoleRenderer batleField;
        private ThorinTeam team;

        public GameEngine(KeyListener userInterface, ConsoleRenderer batleField)
        {
            this.userInterface = userInterface;
            this.batleField = batleField;
            this.allObjects = new List<GameObject>();
            this.DrawBorder();
        }

        private bool IsFinished
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private void DrawBorder()
        {
            for (int row = 0; row < this.batleField.Rows; row++)
            {
                char horizontalWall = (char)(int)Enum.Parse(typeof(WallType), WallType.Horizontal.ToString());
                Wall leftHorizontalWall = new Wall(horizontalWall.ToString(), new Location(row, 0));
                Wall rightHorizontalWall = new Wall(horizontalWall.ToString(), new Location(row, this.batleField.Cols - 1));
                this.AddObject(leftHorizontalWall);
                this.AddObject(rightHorizontalWall);
            }

            for (int col = 0; col < this.batleField.Cols; col++)
            {
                char verticalWall = (char)(int)Enum.Parse(typeof(WallType), WallType.Vertical.ToString());
                Wall leftVerticalWall = new Wall(verticalWall.ToString(), new Location(0, col));
                Wall rightVerticalWall = new Wall(verticalWall.ToString(), new Location(this.batleField.Rows - 1, col));
                this.AddObject(leftVerticalWall);
                this.AddObject(rightVerticalWall);
            }
        }

        public void AddObject(GameObject obj)
        {
            if (obj is ThorinTeam)
            {
                team = obj as ThorinTeam;
            }
            this.allObjects.Add(obj);
        }

        public void Run()
        {
            while (true)
            {
                this.batleField.EnqueueForRendering(this.allObjects);
                this.batleField.RenderAll();

                this.userInterface.ProcessInput();
                BattleHandler battles = CollisionDispatcher.SeeForCollisionsWithEnemies(this.team, this.allObjects);

                if (battles)
                {
                    Console.ReadLine();
                }



                this.batleField.ClearQueue();
                
                Thread.Sleep(150);
            }
        }

        /// <summary>
        /// Displays the title of the game
        /// </summary>
        public void DisplayGameTitle()
        {
            throw new System.NotImplementedException();
        }

        public void DisplayGameRules()
        {
            throw new System.NotImplementedException();
        }

        public void DisplayGameCommands()
        {
            throw new System.NotImplementedException();
        }

        private void ExecuteCommand()
        {
            throw new System.NotImplementedException();
        }

        public void DrawBattleField()
        {
            throw new System.NotImplementedException();
        }

        private void CreateDwarves()
        {
            throw new System.NotImplementedException();
        }

        private void CreateElves()
        {
            throw new System.NotImplementedException();
        }

        private void CreateMagicians()
        {
            throw new System.NotImplementedException();
        }

        private void CreateHobits()
        {
            throw new System.NotImplementedException();
        }

        private void CreateBears()
        {
            throw new System.NotImplementedException();
        }

        private void CreateEagles()
        {
            throw new System.NotImplementedException();
        }

        private void CreateGoblins()
        {
            throw new System.NotImplementedException();
        }

        private void CreateOrks()
        {
            throw new System.NotImplementedException();
        }

        private void CreateTrolls()
        {
            throw new System.NotImplementedException();
        }

        private void CreateWargs()
        {
            throw new System.NotImplementedException();
        }

        private void CreateFood()
        {
            throw new System.NotImplementedException();
        }

        private void CreateWatter()
        {
            throw new System.NotImplementedException();
        }

        private void CreateWeapons()
        {
            throw new System.NotImplementedException();
        }

        private void GetRandomFreeLocation()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Prints on screen the size of the team, the member names, their total strength, their range for running
        /// </summary>
        public void PrintTeamInfo()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Prints messages about what forces are located nearby - 3 bloks in all directions
        /// </summary>
        public void PrintAllocationOfCharacters()
        {
            throw new System.NotImplementedException();
        }

        private void ProcessMove()
        {
            throw new System.NotImplementedException();
        }
    }
}