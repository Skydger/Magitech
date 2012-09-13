using System;
using System.Collections.Generic;
using System.Text;

namespace Concepts
{
    public enum Class{
                       Mage = 1,     Monk = 2,     Scientist = 3,  Psychic = 4,
                       Warrior = 11, Paladin = 12, Technican = 13, Soldier = 14
                      }
    public class NameGetter{
        public static string GetClassName( Class cur_class ){
            string ret = "";
            switch(cur_class){
                case Class.Mage:
                    ret = "Маг";
                    break;
                case Class.Monk:
                    ret = "Жрец";
                    break;
                case Class.Scientist:
                    ret = "Исследователь";
                    break;
                case Class.Psychic:
                    ret = "Паракинетик";
                    break;
                case Class.Warrior:
                    ret = "Воин";
                    break;
                case Class.Paladin:
                    ret = "Паладин";
                    break;
                case Class.Technican:
                    ret = "Инженер";
                    break;
                case Class.Soldier:
                    ret = "Боец";
                    break;
            }
            return ret;
        }
    }
    public class PersonBasics{
        private Class basic_class;
        private int level;
        private int base_health;
        private int base_energy;
        private int base_expirience;
        private static double exp_modifier = 1.12;
        private static double exp_const = 10;

        protected int HealthModifier( int bz ){
            if (bz <= 0) bz = 10;
            return this.level * (this.level + 1) / bz;
        }
        protected int EnergyModifier(int bz){
            if (bz <= 0) bz = 10;
            return this.level * (this.level + 1) / bz;
        }

        protected static int GetExpForLevel(int lvl){
            int exp = (int)(exp_const * Math.Pow(exp_modifier, lvl - 1));
            return exp;
        }

        protected int GetExpirience(){
            if ( this.level == 1 ) this.base_expirience = 10;
            else this.base_expirience = (int)(exp_const * (1 - Math.Pow(exp_modifier, this.level)) / (1 - exp_modifier));
            return this.base_expirience;
        }

        protected void GetBasics(){
            int h_delta = 0;
            int e_delta = 0;
            switch (basic_class){
                case Class.Mage:
                case Class.Psychic:
                    h_delta = this.HealthModifier(22);
                    e_delta = this.EnergyModifier(16);
                    break;
                case Class.Monk:
                case Class.Scientist:
                    h_delta = this.HealthModifier(8);
                    e_delta = this.EnergyModifier(12);
                    break;
                case Class.Paladin:
                case Class.Technican:
                    h_delta = this.HealthModifier(12);
                    e_delta = this.EnergyModifier(8);
                    break;
                case Class.Warrior:
                case Class.Soldier:
                    h_delta = this.HealthModifier(16);
                    e_delta = this.EnergyModifier(4);
                    break;
            }
            this.base_health += h_delta;
            this.base_energy += e_delta;
            this.base_expirience = this.GetExpirience();
        }

        /// <summary>
        /// Максимальный опыт
        /// </summary>
        public int MaxExpirience
        {
            get { return this.base_expirience; }
            //set { this.max_health = value; }
        }
        /// <summary>
        /// Максимальная энергия/мана
        /// </summary>
        public int MaxEnergy
        {
            get { return this.base_energy; }
        }
        /// <summary>
        /// Максимальное чсило повреждений
        /// </summary>
        public int MaxHealth
        {
            get { return this.base_health; }
            set { this.base_health = value; }
        }

        public Class Class{
            get { return this.basic_class; }
            set { this.basic_class = value; }
        }

        public int Level{
            get { return this.level; }
            set {
                this.level = value;
                this.GetBasics();
                }
        }

        public PersonBasics(Class start_class, int start_level){
            this.basic_class = start_class;
            this.level = start_level;
            this.base_health = 5;
            this.base_energy = 5;
            this.base_expirience = 0;
            this.GetBasics();
        }
    }
    
    public class Perk{

    }
    
    public class Personage : PersonBasics {

        //private int max_health;
        //private int max_energy;

        private int health;
        private int energy;

        private int intelligence;
        private int wisdom;
        private int strength;
        private int agility;

        private int expirience;
        private int attack;
        private int defence;

        /// <summary>
        /// Число повреждений
        /// </summary>
        public int Health{
            get { return this.health; }
            set { this.health = value; }
        }


        /// <summary>
        /// Энергия/мана
        /// </summary>
        public int Energy{
            get { return this.energy; }
            set { this.energy = value; }
        }
        /// <summary>
        /// Опыт
        /// </summary>
        public int Expirience{
            get { return this.expirience; }
            set { this.expirience = value; }
        }
        /// <summary>
        /// Атака
        /// </summary>
        public int Attack{
            get { return this.attack; }
            set { this.attack = value; }
        }
        /// <summary>
        /// Защита
        /// </summary>
        public int Defence{
            get { return this.defence; }
            set { this.defence = value; }
        }

        public void LevelUp() { this.Level++;/* base.GetBasics(); */}

        public Personage(Class base_class, int level)
            : base(base_class, level)
        {
            this.health = base.MaxHealth;
            this.energy = base.MaxEnergy;
        }
    }
}
