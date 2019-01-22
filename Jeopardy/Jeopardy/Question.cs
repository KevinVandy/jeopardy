using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeopardy
{
    class Question
    {
        private int Id;
        private int CategoryID;
        private string Type;
        private List<Choice> Choices;
        private string Answer;
        private string State;
        private int Weight;
        private bool DailyDouble;


        public int GetID()
        {
            return Id;
        }

        public void SetID(int Value)
        {
            if(Validator.IsInteger(Value.ToString()))
            {
                Id = Value;
            }
            
        }

        public int GetCategoryID()
        {
            return CategoryID;
        }

        public void SetCategoryID(int Value)
        {
            if(Validator.IsInteger(Value.ToString()))
            {
                CategoryID = Value;
            }
        }

        public string GetType()
        {
            return Type;
        }

        public void SetType(string Value)
        {
            if(Validator.IsPresent(Value))
            {
                Type = Value;
            }
            
        }

        public List<Choice> GetChoices()
        {
            return Choices;
        }

        public void SetChoices(List<Choice> Value)
        {
            if(Value == null || Validator.AreFourChoices(Value))
            {
                Choices = Value;
            }
            
        }

        public string GetAnswer()
        {
            return Answer;
        }

        public void SetAnswer(String Value)
        {
            if(Validator.IsPresent(Value))
            {
                Answer = Value;
            }
            
        }

        public string GetState()
        {
            return State;
        }

        public void SetState(string Value)
        {
            if (Validator.IsPresent(Value))
            {
                State = Value;
            }
        }

        public int GetWeight()
        {
            return Weight;
        }

        public void SetWeight(int Value)
        {
            if(Validator.IsInteger(Value.ToString()))
            {
                Weight = Value;
            }
            
        }

        public bool GetDailyDouble()
        {
            return DailyDouble;
        }

        public void SetDailyDouble(bool Value)
        {
            DailyDouble = Value;
        }
        public Question()
        {

        }
        public Question (int aID, int aCategoryID, string aType, string aAnswer, string aState, int aWeight, bool aDailyDouble, List<Choice> aChoices = null)
        {
            Id = aID;
            CategoryID = aCategoryID;
            Type = aType;
            Choices = aChoices;
            Answer = aAnswer;
            State = aState;
            Weight = aWeight;
            DailyDouble = aDailyDouble;
        }

    }
}
