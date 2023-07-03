using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1
{
    class Class1

    {
        internal class recipe
        {
            //array list to store all recipes details
            public List<string> rec_name = new List<string>();
            List<string> ingr_name = new List<string>();
            List<string> rec_units = new List<string>();
            List<string> rec_steps = new List<string>();
            List<double> rec_qty = new List<double>();
            List<int> rec_calories = new List<int>();
            List<string> rec_food = new List<string>();
            List<double> oldQty = new List<double>();
            string named = "";
            public void addName(string text)
            {

               
                rec_name.Add(text);
                named = text;

            }
            public void Crash()
            {
                rec_name.Add("SELECT BELOW");
            }
            public void SaveIngredients(string name, double quantity, string units, int calories, string group, string names)
            {

                ingr_name.Add(name + names);
                rec_units.Add(units);
                rec_qty.Add(quantity);
                rec_calories.Add(calories);
                rec_food.Add(group);
                oldQty.Add(quantity);


            }

            public void saveSteps(string text)
            {
                
                rec_steps.Add(text + named);
            }

            public void LoadingNames(ComboBox lOADS)
            {
                //
                lOADS.Items.Clear();

                // for loop
                for (int counting = 0; counting < rec_name.Count; counting++)
                {
                    lOADS.Items.Add(rec_name[counting]);
                }


            }

            public void viewed(string text, ListBox listed)
            {
                listed.Items.Clear();

                // for loop
                for (int q = 0; q < ingr_name.Count; q++)
                {

                    //compare or check

                    if (ingr_name[q].Contains(text))
                    {



                      
                        listed.Items.Add("Ingredient name            : " + ingr_name[q].Replace(text, ""));
                       
                        listed.Items.Add("Ingredient Quantity        : " + rec_qty[q]);
                        listed.Items.Add("Ingredient Unit measurement: " + rec_units[q]);
                        listed.Items.Add("Ingredient calories        : " + rec_calories[q]);
                        listed.Items.Add("Ingredient food group      : " + rec_food[q]);
                       

                    }


                }


                listed.Items.Add("steps for    " + text + "                 ");

                // for loop
                for (int q = 0; q < rec_steps.Count; q++)
                {
                    // if statement
                    if (rec_steps[q].Contains(text))
                    {


                        listed.Items.Add("Ingredient step           : " + rec_steps[q].Replace(text, ""));
                       
                    }
                }



            }

            public void scaled(string text, string text1, ListBox listed)
            {


               // for loop
                for (int q = 0; q < ingr_name.Count; q++)
                {

                   // if statement
                    if (ingr_name[q].Contains(text))
                    {




                        rec_qty[q] = rec_qty[q] * double.Parse(text1);


                    }


                }




                // for loop
                for (int q = 0; q < ingr_name.Count; q++)
                {


                    // if statement
                    if (ingr_name[q].Contains(text))
                    {



                       
                        listed.Items.Add("Ingredient name            : " + ingr_name[q].Replace(text, ""));
                        
                        listed.Items.Add("Ingredient Quantity        : " + rec_qty[q]);
                        listed.Items.Add("Ingredient Unit measurement: " + rec_units[q]);
                        listed.Items.Add("Ingredient calories        : " + rec_calories[q]);
                        listed.Items.Add("Ingredient food group      : " + rec_food[q]);
                        

                    }


                }


                listed.Items.Add("steps for    " + text + "                 ");

                // for loop
                for (int q = 0; q < rec_steps.Count; q++)
                {
                    // if statement
                    if (rec_steps[q].Contains(text))
                    {


                        listed.Items.Add("Ingredient step           : " + rec_steps[q].Replace(text, ""));
                       
                    }
                }

            }

            internal void reset(string text, ListBox listed)
            {

                // for loop
                for (int q = 0; q < ingr_name.Count; q++)
                {

                    // if statement
                    if (ingr_name[q].Contains(text))
                    {




                        rec_qty[q] = oldQty[q];
                    }


                }


                listed.Items.Clear();

                // for loop
                for (int q = 0; q < ingr_name.Count; q++)
                {


                    // if statement
                    if (ingr_name[q].Contains(text))
                    {



                       
                        listed.Items.Add("Ingredient name            : " + ingr_name[q].Replace(text, ""));
                      
                        listed.Items.Add("Ingredient Quantity        : " + rec_qty[q]);
                        listed.Items.Add("Ingredient Unit measurement: " + rec_units[q]);
                        listed.Items.Add("Ingredient calories        : " + rec_calories[q]);
                        listed.Items.Add("Ingredient food group      : " + rec_food[q]);
                       
                    }
                }


                listed.Items.Add("steps for    " + text + "                 ");

                // for loop
                for (int q = 0; q < rec_steps.Count; q++)
                {
                    // if statement
                    if (rec_steps[q].Contains(text))
                    {


                        listed.Items.Add("Ingredient step           : " + rec_steps[q].Replace(text, ""));
                       
                    }
                }
            }

            public void clears(string text, ComboBox lOADS)
            {


                // for loop
                for (int m = 0; m < rec_name.Count; m++)
                {


                    // if statement
                    if (rec_name[m].Equals(text))
                    {

                        rec_name.RemoveAt(m);

                        // for loop
                        for (int q
                            = 0; q < ingr_name.Count; q++)
                        {


                            // if statement
                            if (ingr_name[q].Contains(text))
                            {




                                ingr_name.Remove(ingr_name[q].Replace(text, ""));
                                rec_qty.Remove(rec_qty[q]);
                                rec_units.Remove(rec_units[q]);
                                rec_calories.Remove(rec_calories[q]);
                                rec_food.Remove(rec_food[q]);


                            }
                        }

                        // for loop
                        for (int q = 0; q < ingr_name.Count; q++)
                        {

                            // if statement
                            if (ingr_name[q].Contains(text))
                            {




                                rec_steps.Remove(rec_steps[q].Replace(text, ""));



                            }
                        }

                    }
                }

                //
                lOADS.Items.Clear();

                // for loop
                for (int counting = 0; counting < rec_name.Count; counting++)
                {
                    lOADS.Items.Add(rec_name[counting]);
                }


            }
        }
    
}
}
