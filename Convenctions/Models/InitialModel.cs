using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Convenctions.Models
{
    //All the comments will be write in a single line.
    
        //Declarations of classes will be in PascalCase.
    public class InitialModel 
    {
        //-----------------------Class Fields-----------------------

            //For the declaration of de constants We'll be use PascalCase.

        private const int MyNumber = 0;
        public const string MyName = "Hello World!";

            //As you can see the class fields are declared in CamelCase with the underscore at the prefix.

        public int _number; 
        private string _word;
        protected bool _status;
        string[] _collection;

        //-----------------------Properties-----------------------

        //The properties will be declared in Pascal Case

        public byte Age { get; set; }
        public string FirstName { get; set; }
        public bool IsSubscribed { get; set; }

        //-----------------------Constructor of class-----------------------

        //In the constructor can be initialice the class fields or at the moment when declare de variable.

        public InitialModel()
        {
            _number = 1;

            _collection = new string[] { "1", "2", "3", "4" };
        }

        public InitialModel(string firstName)
        {
            this.FirstName = firstName;
        }

        //-----------------------Calculated Properties-----------------------

        public float Passport
        {
            get
            {
                var countOfWatehever = (Age - 18) / 32;

                return countOfWatehever;
            }
        }

        //-----------------------Methods-----------------------

        //Methods will be declared in PascalCase and the name of its parameters in camelCase

        // All methods will execute only a task. The methods that execute multiple tasks will be not considered like a clean code.

        public void ShowName(string name)
        {
            Console.WriteLine(name);
        }
    }

    //1) Enums will be declare in they're particular class.
}