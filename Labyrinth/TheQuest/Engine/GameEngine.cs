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
        private List<GameObject> allObjects;
        private List<Enemy> allEnemies;
        private List<Friend> allFriends;
        private List<Wall> allWalls;
        private KeyListener userInterface;
        private ConsoleRenderer battleField;
        private ThorinTeam team;

        public GameEngine(KeyListener userInterface, ConsoleRenderer batleField)
        {
            this.userInterface = userInterface;
            this.battleField = batleField;

            this.allObjects = new List<GameObject>();
            this.allEnemies = new List<Enemy>();
            this.allWalls = new List<Wall>();
            this.allFriends = new List<Friend>();

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
            for (int row = 0; row < this.battleField.Rows; row++)
            {
                char horizontalWall = (char)(int)Enum.Parse(typeof(WallType), WallType.Horizontal.ToString());
                Wall leftHorizontalWall = new Wall(horizontalWall.ToString(), new Location(row, 0));
                Wall rightHorizontalWall = new Wall(horizontalWall.ToString(), new Location(row, this.battleField.Cols - 1));
                this.AddObject(leftHorizontalWall);
                this.AddObject(rightHorizontalWall);
            }

            for (int col = 0; col < this.battleField.Cols; col++)
            {
                char verticalWall = (char)(int)Enum.Parse(typeof(WallType), WallType.Vertical.ToString());
                Wall leftVerticalWall = new Wall(verticalWall.ToString(), new Location(0, col));
                Wall rightVerticalWall = new Wall(verticalWall.ToString(), new Location(this.battleField.Rows - 1, col));
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
            else if (obj is IEnemy)
            {
                this.allEnemies.Add(obj as Enemy);
            }
            else if (obj is Wall)
            {
                this.allWalls.Add(obj as Wall);
            }
            else if (obj is Friend)
            {
                this.allFriends.Add(obj as Friend);
            }
            this.allObjects.Add(obj);
        }

        public void Run()
        {
            while (true)
            {
                this.battleField.EnqueueForRendering(this.allObjects);
                this.battleField.RenderAll();
                Console.WriteLine(this.team);

                this.userInterface.ProcessInput();

                BattleHandler battles = CollisionDispatcher.SeeForCollisionsWithEnemies(this.team, this.allEnemies);
                if (battles)
                {
                    ConsoleRenderer newBattleField = new ConsoleRenderer(this.battleField.Rows, this.battleField.Cols);
                    BattleEngine battleEngine = new BattleEngine(newBattleField, battles.Friend, battles.Enemy);
                    battleEngine.Run();
                }

                if (CollisionDispatcher.SeeForCollisionsWithWalls(this.team, this.allWalls))
                {
                    this.team.MoveBack();
                }

                Friend friendToJoin = CollisionDispatcher.SeeForCollisionsWithFriends(team, this.allFriends);
                if (friendToJoin != null)
                {
                    this.team.AddCompanion(friendToJoin);
                    friendToJoin.IsAlive = false;
                }

                RemoveAllDeadObjects();

                this.battleField.ClearQueue();
                
                Thread.Sleep(150);
            }
        }

        private void RemoveAllDeadObjects()
        {
            this.allObjects.RemoveAll(x => x.IsAlive == false);
            this.allEnemies.RemoveAll(x => x.IsAlive == false);
            this.allFriends.RemoveAll(x => x.IsAlive == false);
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