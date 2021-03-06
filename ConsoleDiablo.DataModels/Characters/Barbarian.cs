using ConsoleDiablo.DataModels.Characters;
using ConsoleDiablo.DataModels.Contracts.Characters;
using System;

namespace ConsoleDiablo.App.Entities.Characters
{
    public class Barbarian : Character, IBarbarian
    {
        public Barbarian(int id, string name, string type, bool isDeleted, int gearId, int inventoryId, int accountId) : base 
            (id, name, "Barbarian", isDeleted,
            damage: 50,
            defense: 50,
            baseLife: 200,
            baseMana: 20,
            gearId,
            inventoryId,
            accountId)        
        {
        }

        public Barbarian(int id,
                    string name,
                    string type,
                    bool isDeleted,
                    DateTime dateCreated,
                    double damage,
                    double defense,
                    double baseLife,
                    double life,
                    double lifeRegenerationMultiplier,
                    double baseMana,
                    double mana,
                    double manaRegenerationMultiplier,
                    double experience,
                    int level,
                    double fireResistance,
                    double lightningResistance,
                    double coldResistance,
                    double poisonResistance,
                    int gearId,
                    int inventoryId,
                    double moneyBalance,
                    int accountId) : base(
                                          id,
                                          name,
                                          type,
                                          isDeleted,
                                          dateCreated,
                                          damage,
                                          defense,
                                          baseLife,
                                          life,
                                          lifeRegenerationMultiplier,
                                          baseMana,
                                          mana,
                                          manaRegenerationMultiplier,
                                          experience,
                                          level,
                                          fireResistance,
                                          lightningResistance,
                                          coldResistance,
                                          poisonResistance,
                                          gearId,
                                          inventoryId,
                                          moneyBalance,
                                          accountId)
        {

        }

        //public void UseBarbarianAbility(Character character, BarbarianAbility barbAbility)
        //{
        //    EnsureAlive();

        //    if (barbAbility is Battlecry & character.Mana >= barbAbility.ManaCost)
        //    {
        //        barbAbility.AffectCharacter(character);
        //    }
        //    else if (barbAbility is Ferocity & character.Mana >= barbAbility.ManaCost)
        //    {
        //        barbAbility.AffectCharacter(character);
        //    }
        //    else
        //    {
        //        throw new ArgumentException($"{character.Name} does not have enough mana to perform this action.");
        //    }
        //}
    }
}
