﻿
namespace BuilderPerson
{
    public class HeroBuilder : ICharacterBuilder
    {
        private readonly Character character  = new ();
        public ICharacterBuilder SetBuild(string build)
        {
            character.Build = build;
            return this;
        }
        

        public ICharacterBuilder SetClothing(string clothing)
        {
            character.Clothing = clothing;
            return this;
        }

        public ICharacterBuilder SetEyeColor(string eyeColor)
        {
            character.EyeColor = eyeColor;
            return this;
        }

        public ICharacterBuilder SetHairColor(string hairColor)
        {
            character.HairColor = hairColor;
            return this;
        }

        public ICharacterBuilder SetHeight(double height)
        {
            character.Height = height;
            return this;
        }

        public ICharacterBuilder SetInventory(List<string> inventory)
        {
            character.Inventory = inventory;
            return this;
        }

        Character ICharacterBuilder.Build()
        {
            return character;
        }
    }
}
