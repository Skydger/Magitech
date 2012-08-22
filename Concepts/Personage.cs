using System;
using System.Collections.Generic;
using System.Text;

namespace Concepts
{
    public enum Class{
                       Mage = 1,     Monk = 2,     Scientist = 3,  Psychic = 4,
                       Warrior = 11, Paladin = 12, Technican = 13, Soldier = 14
                      }
    public class PersonBasics{
        private Class basic_class;
        private int level;
        private int base_health;
        private int base_energy;
        private int base_expirience;
        private static double exp_modifier = 1.2;

        protected int HealthModifier(){
            return this.level * (this.level + 1) / 2;
        }
        protected int EnergyModifier(){
            return this.level * (this.level + 1) / 2;
        }

        protected int GetExpirience(){
            if ( this.level == 1 ) this.base_expirience = 10;
            else this.base_expirience = (int)(10 * (1 - Math.Pow(exp_modifier, this.level)) / (1 - exp_modifier));
            return this.base_expirience;
        }

        protected void GetBasics(){
            int h_delta = 0;
            int e_delta = 0;
            switch (basic_class){
                case Class.Mage:
                case Class.Psychic:
                    h_delta = 5 + this.HealthModifier();
                    e_delta = 15 + this.EnergyModifier();
                    break;
                case Class.Monk:
                case Class.Scientist:
                    h_delta = 8 + this.HealthModifier();
                    e_delta = 12 + this.EnergyModifier();
                    break;
                case Class.Paladin:
                case Class.Technican:
                    h_delta = 12 + this.HealthModifier();
                    e_delta = 8 + this.EnergyModifier();
                    break;
                case Class.Warrior:
                case Class.Soldier:
                    h_delta = 15 + this.HealthModifier();
                    e_delta = 5 + this.EnergyModifier();
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

        public int Level{
            get { return this.level; }
            set { this.level = value; }
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

        public void LevelUp() { this.Level++; base.GetBasics(); }

        public Personage(Class base_class, int level)
            : base(base_class, level)
        {
            this.health = base.MaxHealth;
            this.energy = base.MaxEnergy;
        }
    }
}
