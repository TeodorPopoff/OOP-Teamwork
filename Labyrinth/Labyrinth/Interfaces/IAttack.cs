namespace Labyrinth.Interfaces
{
    using Labyrinth.Objects;

    interface IAttack
    {
        double AttackPoints {get; set;}

        void Attack(Creature creature);
    }
}
