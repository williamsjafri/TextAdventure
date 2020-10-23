using System;
using System.Runtime.CompilerServices;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"You woke up in an empty room with three items beside you. The items are:");
            Console.WriteLine($"lighter");
            Console.WriteLine($"loaded gun");
            Console.WriteLine($"gas mask");
            Console.WriteLine($"A note was attached to one of the items.");
            Console.WriteLine($"It says: 'You are now in a haunted asylum. You must leave this place before the ghosts catch up and kill you. Choose only 2 items for you to use. Choose wisely.'");
            Console.WriteLine($"Please enter the items below.");
            String item1 =Console.ReadLine().ToLower();
            String item2 =Console.ReadLine().ToLower();
            Console.WriteLine($"Please continue to the next room.");
            Console.WriteLine($"You are now in room 2. You noticed there is an empty backpack.");
            Console.WriteLine($"Do you pick it up?");
            string pickUp = Console.ReadLine().ToLower();
            if (pickUp=="yes")
            {
                Console.WriteLine($"You can now carry 3 more items. Look for them in the next rooms.");
                Console.WriteLine($"You encountered a locked door ahead of you. You can find the key to the door in the room.");
                Console.WriteLine($"You can also use one of your item if appropriate.");
                Console.WriteLine($"How do you unlock the door? Find key or use item?");
                string choice1 =Console.ReadLine().ToLower();
                if (choice1 == "find key") 
                {
                    Console.WriteLine($"Where do you search?");
                   
                        string place1 = Console.ReadLine().ToLower();
                        switch (place1)
                        {
                            case "drawer":
                                Console.WriteLine($"Congratulations, you found the key.");
                                break;
                                
                            
                            default:
                            Console.WriteLine($"Try Again");
                            for (int i = 0; i < 2; i++)
                            {
                                string place2= Console.ReadLine().ToLower();
                            
                               
                                if (place2=="drawer")
                                {
                                    Console.WriteLine($"Congratulations, you found the key.");
                                } 
                                else if (i==1)
                                {
                                    Console.WriteLine($"You died for taking too long.");
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine($"Try Again");
                                }
                            }
                                break;
                            
                        }

                }
                else
                {
                    Console.WriteLine($"Which item are you using? You have {item1} and {item2}");
                        string item = Console.ReadLine().ToLower();
                        switch (item)
                        {
                            case "loaded gun":
                                
                                    Console.WriteLine($"Nice choice! You can now go through the door.");
                                break;
                            default:
                                Console.WriteLine($"This item can not be used. You died for taking to long.");
                                return;
                        }
                    
                }
                Console.WriteLine($"You found a fellow human. She is under attack. Save her or not?");
                string choice2 = Console.ReadLine().ToLower();
                if (choice2 == "yes")
                {
                    Console.WriteLine($"You saved the girl.");
                    Console.WriteLine($"She gave you the final key to the exit.");
                    Console.WriteLine($"Both of you exit and live happily ever after.");
                }
                else
                {
                    Console.WriteLine($"The girl perished in the hands of ghosts.");
                    Console.WriteLine($"You head towards the exit but it turns out it is locked.");
                    Console.WriteLine($"You can't find the key and the ghosts are heading towards you.");
                    Console.WriteLine($"You tried to fight back but unfortunately the ghosts overpowered you and killed you.");
                }
            }
            else
            {
                Console.WriteLine($"You can only carry two items for the next rooms.");
                Console.WriteLine($"You encountered a locked door ahead of you. You can find the key to the door in the room.");
                Console.WriteLine($"You can also use the right item to unlock the door.");
                Console.WriteLine($"Find key or use item?");
                string choice1 = Console.ReadLine().ToLower();
                if (choice1=="find key")
                {
                   
                        Console.WriteLine($"Where do you search?");

                        string place1 = Console.ReadLine().ToLower();
                        switch (place1)
                        {
                            case "drawer":
                            Console.WriteLine($"You can only carry 2 items.");
                            Console.WriteLine($"Choose one item to drop. {item1} and {item2}");
                            string dropItem = Console.ReadLine();
                            string item3 = "Key";
                                Console.WriteLine($"Congratulations, you found the key.");
                                break;


                            default:
                                Console.WriteLine($"Try Again");
                                for (int i = 0; i < 2; i++)
                                {
                                    string place2 = Console.ReadLine().ToLower();


                                    if (place2 == "drawer")
                                    {
                                        Console.WriteLine($"Congratulations, you found the key.");
                                    }
                                    else if (i == 1)
                                    {
                                        Console.WriteLine($"You died for taking too long.");
                                        return;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Try Again");
                                    }
                                }
                                break;

                        }



                    }
                else
                {
                    Console.WriteLine($"Which item are you using? You have {item1} {item2}");
                    string item = Console.ReadLine().ToLower();
                    switch (item)
                    {
                        case "loaded gun":

                            Console.WriteLine($"Nice choice! You can now go through the door.");
                            break;
                        default:
                            Console.WriteLine($"This item can not be used. You died for taking to long.");
                            return;
                    }

                }
                Console.WriteLine($"You found a fellow human. She is under attack. Save her or not?");
                string choice2 = Console.ReadLine().ToLower();
                if (choice2 == "yes")
                {
                    Console.WriteLine($"You saved the girl.");
                    Console.WriteLine($"She gave you the final key to the exit.");
                    Console.WriteLine($"Both of you exit and live happily ever after.");
                }
                else
                {
                    Console.WriteLine($"The girl perished in the hands of ghosts.");
                    Console.WriteLine($"You head towards the exit but it turns out it is locked.");
                    Console.WriteLine($"You can't find the key and the ghosts are heading towards you.");
                    Console.WriteLine($"You tried to fight back but unfortunately the ghosts overpowered you and killed you.");
                }

            }
            Console.WriteLine($"The End");
            
        }
    }
}
