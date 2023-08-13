namespace С__Pack
{
    using System;
    using System.Collections.Generic;

        namespace UserRegistrationQuizApp
    {
        class Program
        {
            struct UserData
            {
                public string Password;
                public string Birthdate;
            }
            static Dictionary<string, UserData> users = new Dictionary<string, UserData>();
            static Dictionary<string, string> quizQuestions = new Dictionary<string, string>
        {
            { "Who was the founder of the Communist Party of China?", "Mao Zedong" },
            { "In which year was the Communist Party of China founded?", "1921" },
            { "When 'Great Leap Forward' started?", "1958" },
            { "Who was the leader of China during the 'Great Leap Forward", "Mao Zedong" },
            { "When did Communist Republic of China won in a Chinese Civil War?", "1949" },
            { "When did Tiananmen Square protests happened?", "1989" },
            { "When did the 'One-Child Policy' started?", "1980" },
            { "In what year the transition of Hong Kong's sovereignty from British rule to Chinese rule happened?", "1997" },
            { "When did the Long March, a significant event in Communist history, begin?", "1934" },
            { " In which year was the Communist Party of China founded?", "1921" },
            { "When did the Chinese government establish diplomatic relations with the United States?", "1979" },
            { "In which year did China join the World Trade Organization (WTO)?", "2001" },
            { "In which year was the Beijing Olympics held?", "2008" },
            { "When did Xi Jinping become the General Secretary of the Communist Party of China?", "2012" },
            { "In which year was the \"Belt and Road Initiative\" officially announced?", "2013" },
            { "When did China land its rover on the moon's surface in the Chang'e-4 mission?", "2019" },
            { "In which year did China grapple with the COVID-19 pandemic?", "2020" },
            { "When is the 100th anniversary of the founding of the Communist Party of China?", "2021" },
        };

            static bool IsUserRegistered(string username)
            {
                return users.ContainsKey(username);
            }

            static bool RegisterUser(string username, string password, string birthdate)
            {
                if (IsUserRegistered(username))
                {
                    return false;
                }

                users[username] = new UserData { Password = password, Birthdate = birthdate };
                return true;
            }

            static void RunQuiz()
            {
               
 Console.WriteLine("................................................ ....   ........................");
 Console.WriteLine(".,,,.,,.,.,,,,,,.,.,...,.,,,*% &@&&@&&% ((/ (((#&&&&&,,,......,....................");
 Console.WriteLine(" ,,,,,,,,,,,,,,,,.,,,,,#@@&@@@&@%(//*****,*****,*,,&&&%%*........................");
 Console.WriteLine(",,,,,,,,.,,,,,,,.,, &@@@@@&& &##(//*****,,,,,,,,,,,,,,,#@%%%&@(.,.........,.......");
 Console.WriteLine(",,,,,,,,,,,,,,...(@@@@@@@@%##(/(/******,,,,,,,,,,,,,.,,,&@@%&&&/.........,.,....");
 Console.WriteLine(",,,,,,,,,,,,.,,,#@@@@@@&&%###(///******,,,,,,,,,,....,,,,*&&&%&@%...,...........");
 Console.WriteLine(",,,,,,,,,,,,....@@@@@@@@@%##(((/******,,,,,,,,,........,,,*&&&##@&..............");
 Console.WriteLine(",,,,,,,,.,,.....@@@@@@@@@###((//****,,,,,.,,,,,........,,,*(&%%%&@,.............");
 Console.WriteLine(",,,,,,,,,..,....(@@@@@@&##((((//****,,*,,,,,,.,........,,,,/&%&%@%(.............");
 Console.WriteLine(".,,,,,,,,,,...... &&@@@%###((#((%###%##/**,,,,(((##(*,,,,,,,*%%%&%%..............");
 Console.WriteLine(".,,,,,,,,,,,.,....#@@&###(#(///*##%,,.,**,,..,,***,,.,,,,,,,(%&&*...............");
 Console.WriteLine(",,,,,,,,,,,,,,.....&@#(##(((#&&(@&,(%,/**,,...(#&&@@#//,,,,,,&%.................");
 Console.WriteLine(",,,,,,,,,,,,,,....,&&##((***/****,*,.****,,.,,,**,,...,**,.,,&..................");
 Console.WriteLine(",,,,,,,,,,,,,,,,,,/ &##(((/**,,,*******//*,,...,..,**,,,....,*%(.................");
 Console.WriteLine(".,,.,,,,.,,,,,,,,,&/##(((/***,,,,,,*/(((*,,..,,,.........,,,*%*.................");
 Console.WriteLine(".,,...,,,.,,,,,,,#@%#%###(//****,,,##(##(/*,,,.*/,. ...,,*****,.................");
 Console.WriteLine(",,,........,,.,.,/####%###(///***/%%#&@@%%&@@&(,,//*,,,,,,***.,.................");
 Console.WriteLine(",.,......,..,....,((##%####(/////*******,.,.......*/****,*,*,*,.................");
 Console.WriteLine(",,, .., .........,.,,.,%#####(((((/(//****,.,,,,,,.,,*///*****.,..................");
 Console.WriteLine(",., ..,, .........,,,..#%%##%(////&@%&&%%%&&%%&%&&&((**/******...............,,..,");
 Console.WriteLine(".,.,.,,,,.,...,...,.. /%%#%#%(/*/(//######(**,,,,.,(/*******..............,,,,,..");
 Console.WriteLine(".,,,,,,,,,,.........%@%%%%%#%(((///*******,,,,,,,,//******...........,..,,,,,,.,");
 Console.WriteLine(",,,,,.,....,.......&&@@@#%%%%%&%##/*//***/*,,,,,,*/(//((...............,..,,.,.,");
Console.WriteLine(",,,,,.,....,.......&&@@@#%%%%%&%##/*//***/*,/,*,(*((//((...............,..,,.,.,");

                Console.WriteLine("Welcome to the Quiz!");
                int score = 0;

                foreach (var question in quizQuestions)
                {
                    Console.WriteLine(question.Key);
                    string userAnswer = Console.ReadLine();

                    if (userAnswer.ToLower() == question.Value.ToLower())
                    {
                        Console.WriteLine("Correct!\n");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect. The correct answer is: {question.Value}\n");
                    }
                }

                Console.WriteLine($"Quiz completed! Your score: {score}/{quizQuestions.Count}");
            }

            static void Main(string[] args)
            {
                while (true)
                {
                    Console.Write("Enter your username: ");
                    string username = Console.ReadLine();

                    if (IsUserRegistered(username))
                    {
                        Console.Write("Enter your password: ");
                        string password = Console.ReadLine();

                        if (password == users[username].Password)
                        {
                            Console.WriteLine($"Welcome, {username}!");
                            RunQuiz();
                        }
                        else
                        {
                            Console.WriteLine("Incorrect password.");
                        }
                    }
                    else
                    {
                        Console.Write("User not found. Would you like to register? (yes/no): ");
                        string choice = Console.ReadLine();

                        if (choice.ToLower() == "yes")
                        {
                            Console.Write("Enter your password: ");
                            string password = Console.ReadLine();
                            Console.Write("Enter your birthdate: ");
                            string birthdate = Console.ReadLine();

                            if (RegisterUser(username, password, birthdate))
                            {
                                Console.WriteLine("Registration successful.");
                            }
                            else
                            {
                                Console.WriteLine("Username already exists. Registration failed.");
                            }
                        }
                    }
                }
            }
        }
    }
}
