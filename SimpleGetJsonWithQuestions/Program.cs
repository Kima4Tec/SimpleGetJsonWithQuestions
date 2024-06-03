using Newtonsoft.Json;

namespace SimpleGetJsonWithQuestions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string category;
            string filepath;

            //Run a loop til user has entered one of the categories
            do
            {
            Console.WriteLine("Hvilken kategori vil du gerne spørges om?");
                Console.WriteLine();

                Console.WriteLine("a) Vand og klima");
                Console.WriteLine("b) MS SQL");
                Console.WriteLine("c) C#");
            
                userInput = Console.ReadLine().ToLower();
                if ((!(userInput == "a" || userInput == "b" || userInput == "c")))
                {
                    Console.WriteLine("Ugyldigt valg.");
                    Console.ReadLine();
                }

                Console.Clear();

            } while ((!(userInput == "a" || userInput == "b" || userInput == "c")));

            if (userInput == "a")
            {
                category = "Vand og Klima";

                //Path to json file. Mine is in the folder MyJsonFile. Chenged property of json file from copy never to copy always 
                filepath = "MyJsonFiles/QuestionAndAnswersWater.json";
            }
            else if (userInput == "b")
            {
                category = "MS SQL";
                //Path to json file. Mine is in the folder MyJsonFile. Chenged property of json file from copy never to copy always 
                filepath = "MyJsonFiles/QuestionAndAnswersSQL.json";
            }
            else if (userInput == "c")
            {
                category = "C#";
                //Path to json file. Mine is in the folder MyJsonFile. Chenged property of json file from copy never to copy always 
                filepath = "MyJsonFiles/QuestionAndAnswersCSharp.json"; 
            }
            else
            {
                return;
            }

            //Read text in json file
            string json = File.ReadAllText(filepath);

            //Define List for all the questions in json file
            List<JsonData> allQuestions;

            //Desisrialize json file and add the questions to the list allQuestions
            allQuestions = JsonConvert.DeserializeObject<List<JsonData>>(json);

            //create an instance of the class Questions, where questions is the object
            Questions questions = new Questions();

            //call the method HandleQuestions with the argument allQuestions
            questions.HandleQuestions(category, allQuestions);
        }

        //Properties aligning with the data in the json file you want to get
        public class JsonData
        {
            public string Question { get; set; }
            public List<string> Options { get; set; }
            public int Answer { get; set; }
            public string Explanation { get; set; }
        }

        public class Questions
        {
            /// <summary>
            /// Handle the questions for the user.
            /// </summary>
            /// <param name="category"></param>
            /// <param name="allQuestions"></param>
            public void HandleQuestions(string category, List<JsonData> allQuestions)
            {
                //integers for counting right and wrong answers
                int countRightAnswer = 0;
                int countWrongAnwer = 0;

                //For every question in the list allQuestions, do this:
                for (int i = 0; i < allQuestions.Count; i++)
                {
                    //Clear screen
                    Console.Clear();

                    //Print out the chosen category in blue
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Kategori: {category}");
                    Console.ResetColor();

                    //Print out the question
                    Console.WriteLine(allQuestions[i].Question);
                    Console.WriteLine();

                    //Printout the user options
                    Console.WriteLine($"0) {allQuestions[i].Options[0]}");
                    Console.WriteLine($"1) {allQuestions[i].Options[1]}");
                    Console.WriteLine($"2) {allQuestions[i].Options[2]}");
                    Console.WriteLine();

                    //Get the right answeer
                    int rightAnswer = allQuestions[i].Answer;

                    //Bool for checking if users input is an integer 
                    bool validateInput = false;

                    //Loop while answer is not an integer
                    while (!validateInput)
                    {

                        Console.WriteLine("Hvilket svar er rigtigt? Indtast 0, 1 eller 2.");

                        string userInput = Console.ReadLine();
                        Console.WriteLine();

                        //TryParse returns a boolean, and when true, output the users input into userAnswer
                        bool bUserInput = int.TryParse(userInput, out int userAnswer);

                        //if users input is an integer checked by TryParse
                        if (bUserInput)
                        {
                            //Check if answer is correct
                            if (userAnswer == rightAnswer)
                            {
                                Console.WriteLine("Flot! Det var rigtigt!");
                                Console.WriteLine();

                                //Add one to countRightAnswer
                                countRightAnswer++;
                            }
                            else
                            {
                                Console.WriteLine("Øv...Det var forkert.");
                                Console.WriteLine();

                                //Add one to countWrongAnwer
                                countWrongAnwer++;
                            }
                            //Validation is done. User input was an integer
                            validateInput = true;
                        }
                        else
                        {
                            //When user input was not an integer
                            Console.WriteLine("Du skal indtaste 0, 1 eller 2.");
                        }
                    }
                    //Print out an explanation to the questions
                    Console.WriteLine(allQuestions[i].Explanation);

                    Console.WriteLine("Tryk ENTER for næste spørgsmål");
                    Console.ReadLine();
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Dit resultat: ");
                Console.ResetColor();
                Console.WriteLine($"Antal rigtige: {countRightAnswer}");
                Console.WriteLine($"Antal forkerte: {countWrongAnwer}");
                Console.ReadLine();

            }
        }
    }
}
