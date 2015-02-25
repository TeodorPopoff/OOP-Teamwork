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

        private const int MaxNumberOfOrks = 30;
        private const int MaxNumberOfGoblins = 25;
        private const int MaxNumberOfTrolls = 20;
        private const int MaxNumberOfWargs = 20;

        private const int MaxNumberOfBears = 20;

        private const int MaxNumberOfEagles = 20;
        private const int MaxNumberOfHorses = 20;
        private const int MaxNumberOfFood = 30;
        private const int MaxNumberOfWeapons = 30;


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

        public ThorinTeam Team
        {
            get
            {
                return this.team;
            }
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

        /// <summary>
        /// Creates all charactres and items that will participate
        /// int the game.
        /// </summary>
        public void InitAllGameObjects()
        {
            this.AddObject(new ThorinTeam());
            CreateBears();
            CreateDwarves();
            CreateElves();
            CreateEnemies();
            CreateHobits();
            CreateItems();
            CreateMagicians();
        }

        private void ExecuteCommand()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Creates the dwarves...
        /// </summary>
        private void CreateDwarves()
        {
            List<Dwarf> dwarves = new List<Dwarf>();
            this.AddObject(new Dwarf(DwarfNames.Balin.ToString(), GetRandomFreeLocation()));
            this.AddObject(new Dwarf(DwarfNames.Bifur.ToString(), GetRandomFreeLocation()));
            this.AddObject(new Dwarf(DwarfNames.Bofur.ToString(), GetRandomFreeLocation()));
            this.AddObject(new Dwarf(DwarfNames.Bombur.ToString(), GetRandomFreeLocation()));
            this.AddObject(new Dwarf(DwarfNames.Dori.ToString(), GetRandomFreeLocation()));
            this.AddObject(new Dwarf(DwarfNames.Dwalin.ToString(), GetRandomFreeLocation()));
            this.AddObject(new Dwarf(DwarfNames.Fili.ToString(), GetRandomFreeLocation()));
            this.AddObject(new Dwarf(DwarfNames.Gloin.ToString(), GetRandomFreeLocation()));
            this.AddObject(new Dwarf(DwarfNames.Kili.ToString(), GetRandomFreeLocation()));
            this.AddObject(new Dwarf(DwarfNames.Nori.ToString(), GetRandomFreeLocation()));
            this.AddObject(new Dwarf(DwarfNames.Oin.ToString(), GetRandomFreeLocation()));
            this.AddObject(new Dwarf(DwarfNames.Ori.ToString(), GetRandomFreeLocation()));
        }

        /// <summary>
        /// Creates the elves...
        /// 
        /// </summary>
        private void CreateElves()
        {
            this.AddObject(Elrond.GetInstance(GetRandomFreeLocation()));
            this.AddObject(Galadriel.GetInstance(GetRandomFreeLocation()));
            this.AddObject(Legolas.GetInstance(GetRandomFreeLocation()));
            this.AddObject(Tauriel.GetInstance(GetRandomFreeLocation()));
            this.AddObject(Thranduil.GetInstance(GetRandomFreeLocation()));
        }

        /// <summary>
        /// Creates the magicians...
        /// </summary>
        private void CreateMagicians()
        {
            this.AddObject(new AngmarKing(GetRandomFreeLocation()));
            this.AddObject(new Gandalf(GetRandomFreeLocation()));
            this.AddObject(new Necromancer(GetRandomFreeLocation()));
            this.AddObject(new Radagast(GetRandomFreeLocation()));
            this.AddObject(new Saruman(GetRandomFreeLocation()));
        }

        /// <summary>
        /// Creates the Hobbits - only Bilbo currently.
        /// </summary>
        private void CreateHobits()
        {
            RingBearer bilbo = new RingBearer(GetRandomFreeLocation());
            this.AddObject(bilbo);
        }

        /// <summary>
        /// Creates bears and puts the into the collection allObjects.
        /// </summary>
        private void CreateBears()
        {
            Random rnd = new Random();
            int count = rnd.Next(0, MaxNumberOfBears + 1);
            for (int i = 0; i < count; i++)
            {
                Location location = GetRandomFreeLocation();
                Bear newBear = new Bear("Bear " + i, location);
                this.AddObject(newBear);
            }
        }

        /// <summary>
        /// Creates the four types of items and adds
        /// them to the engine.
        /// </summary>
        private void CreateItems()
        {
            Random rnd = new Random();

            //Create eagles:
            int count = rnd.Next(0, MaxNumberOfEagles + 1);
            for (int i = 0; i < count; i++)
            {
                Location location = GetRandomFreeLocation();
                Eagles newEagles = new Eagles(location);
                this.AddObject(newEagles);
            }

            //Create horses:
            count = rnd.Next(0, MaxNumberOfHorses + 1);
            for (int i = 0; i < count; i++)
            {
                Location location = GetRandomFreeLocation();
                Horses horses = new Horses(location);
                this.AddObject(horses);
            }

            //Create weapons:
            count = rnd.Next(0, MaxNumberOfWeapons + 1);
            for (int i = 0; i < count; i++)
            {
                Location location = GetRandomFreeLocation();
                Weapons weapons = new Weapons(location);
                this.AddObject(weapons);
            }

            //Create food:
            count = rnd.Next(0, MaxNumberOfFood + 1);
            for (int i = 0; i < count; i++)
            {
                Location location = GetRandomFreeLocation();
                Food food = new Food(location);
                this.AddObject(food);
            }
        }

        private void CreateEnemies()
        {
            Random rnd = new Random();

            //Create orcs:
            int count = rnd.Next(0, MaxNumberOfOrks + 1);
            for (int i = 0; i < count; i++)
            {
                Location location = GetRandomFreeLocation();
                Ork ork = new Ork("Ork " + i, location);
                this.AddObject(ork);
            }

            //Create goblins:
            count = rnd.Next(0, MaxNumberOfGoblins + 1);
            for (int i = 0; i < count; i++)
            {
                Location location = GetRandomFreeLocation();
                Goblin goblin = new Goblin("Goblin " + i, location);
                this.AddObject(goblin);
            }

            //Create trolls:
            count = rnd.Next(0, MaxNumberOfTrolls + 1);
            for (int i = 0; i < count; i++)
            {
                Location location = GetRandomFreeLocation();
                Troll troll = new Troll("Troll " + i, location);
                this.AddObject(troll);
            }

            //Create wargs:
            count = rnd.Next(0, MaxNumberOfWargs + 1);
            for (int i = 0; i < count; i++)
            {
                Location location = GetRandomFreeLocation();
                Warg warg = new Warg("Warg " + i, location);
                this.AddObject(warg);
            }
        }

        /// <summary>
        /// Prints on screen the size of the team, the member names, their total strength, their range for running
        /// </summary>
        public void PrintTeamInfo()
        {
            Console.WriteLine(this.team.ToString());
        }

        /// <summary>
        /// Prints messages about what forces are located nearby - 3 bloks in all directions
        /// </summary>
        public void PrintAllocationOfCharacters()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Gets a position on the battlefield that is currently not taken by any character.
        /// </summary>
        private Location GetRandomFreeLocation()
        {
            int x = 0;
            int y = 0;
            Random rnd = new Random();
            bool isFree = false;
            while (isFree == false)
            {
                x = rnd.Next(0, this.battleField.Rows);
                y = rnd.Next(0, this.battleField.Cols);
                isFree = IsLocationFree(new Location(x, y));
            }
            return new Location(x, y);
        }

        /// <summary>
        /// Checks if a given location on the battlefiled is
        /// taken by another object.
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        private bool IsLocationFree(Location location)
        {
            foreach (var item in this.allObjects)
            {
                if (item.Position.X == location.X && item.Position.Y == location.Y)
                {
                    return true;
                }
            }
            return false;
        }
    }
}