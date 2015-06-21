using HowToBBQ.Models;
using System;
using Windows.ApplicationModel;
using Windows.UI.Xaml.Navigation;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace HowToBBQ.ViewModels
{
    public class MainViewModel : Mvvm.ViewModelBase
    {

        public ObservableCollection<BBQRecipe> Recipes  { get; set; }

        private string prefix = @"/Images/";

        public MainViewModel()
        {

            if (!App.IsDataLoaded)
            {
                LoadData();
                Recipes = App.dbRecipes;
            }
        }
        public override void OnNavigatedTo(string parameter, NavigationMode mode, System.Collections.Generic.IDictionary<string, object> state)
        {
            this.Recipes = App.dbRecipes;
        }
        public void GotoRecipe(string recipe)
        { 
            this.NavigationService.Navigate(typeof(Views.RecipePage), recipe);
        }

        private void LoadData()
        {

            ObservableCollection<BBQRecipe> _returnRecipes = new ObservableCollection<BBQRecipe>();

            _returnRecipes.Add(new BBQRecipe
            {
                Name = "Dry Glazed Pork Tenderloin",
                ShortDesc = "",
                Ingredients = string.Concat("3 light brown sugar, packed", Environment.NewLine,
                                            "3 clove garlic, minced", Environment.NewLine,
                                            "1 tbsp finely grated orange zest", Environment.NewLine,
                                            "3 tbsp paprika", Environment.NewLine,
                                            "1 tbsp sesame seeds", Environment.NewLine,
                                            "1 tbsp ground ginger", Environment.NewLine,
                                            "1 tbsp ground coriander", Environment.NewLine,
                                            "2 tsp fine salt", Environment.NewLine,
                                            "2 tsp ground black pepper", Environment.NewLine,
                                            "1 tsp cream of tartar", Environment.NewLine,
                                            "3 1 lb. pork tenderloins"),
                Directions = string.Concat("1. For dry glaze, stir brown sugar, garlic and orange zest to blend. In a separate bowl, stir remaining ingredients, then add to brown sugar mixture. Set aside until ready to use.", Environment.NewLine,
                                           "2. Clean pork tenderloin of any connective tissue. Preheat grill to medium and clean well. Rub tenderloins completely with dry glaze and immediately place on grill. Grill, uncovered, for about 8 minutes on each side until an internal temperature of 165°F is reached, rotating tenderloins 90° on each side. Let pork sit for a moment before slicing and serving."
                                           ),
                Serves = 10,
                PrepTime = 0,
                TotalTime = 0,
                ImageSource = prefix + "DryGlazedPorkTenderloin.jpg"
            });

            _returnRecipes.Add(new BBQRecipe
            {
                Name = "Grilled Pork Chops and Zesty Sauce Vierge with Feta",
                ShortDesc = "",
                Ingredients = string.Concat("2 tbsp (30 ml) melted butter", Environment.NewLine,
                                            "4 pork chops, 150 g (1/3 lb) each", Environment.NewLine,
                                            "3/10 cup cup (80 ml) red onion, chopped", Environment.NewLine,
                                            "2 tbsp (30 ml) butter", Environment.NewLine,
                                            "1 large tomato, seeded and diced (or 2 Italian tomatoes)", Environment.NewLine,
                                            "½ cup (125 ml) black olives, chopped", Environment.NewLine,
                                            "3 tbsp (45 ml) capers, drained", Environment.NewLine,
                                            "2 tbsp (2 ml) lemon zest, finely chopped", Environment.NewLine,
                                            "1 tbsp (15 ml) lemon juice", Environment.NewLine,
                                            "1 tbsp (5 ml) orange zest, finely chopped", Environment.NewLine,
                                            "2 to 3 tbsp (30 to 45 ml) orange juice", Environment.NewLine,
                                            "½ cup (125 ml) Canadian Feta, crumbled or diced small", Environment.NewLine,
                                            "Ground pepper to taste"),
                Directions = string.Concat("1. Brush the pork chops with melted butter and season them. Preheat the barbecue or a grill pan to medium-high and cook the pork chops, turning them only once. Cook each side for about 4 minutes depending on the thickness and desired doneness (pork is tender and delicious served pink).", Environment.NewLine,
                                           "2. While the pork is cooking, in a saucepan, cook the onion in butter over medium heat for 2 minutes. Add the remaining vegetables and the citrus juice and zest. Pepper to taste. Bring to a boil and remove from the heat. Set aside covered. Add the Feta to the sauce.", Environment.NewLine,
                                           "3. Serve the grilled pork accompanied by the sauce and pasta. Coat the pasta with the remaining sauce."
                ),
                PrepTime = 10,
                TotalTime = 22,
                Serves = 4,
                ImageSource = prefix + "GrilledPorkChopsandZestySauceViergewithFeta.jpg"

            });

            _returnRecipes.Add(new BBQRecipe
            {
                Name = "St. Louis Style Pork Ribs",
                ShortDesc = "Bad to the bone gets a whole new meaning with our fabulous, fall-off-the-bone ribs, all wrapped up in a fool-proof recipe package.",
                Ingredients = string.Concat("2 rack St. Louis-style pork ribs", Environment.NewLine,
                                            "½ cup brown sugar", Environment.NewLine,
                                            "2 tbsp paprika", Environment.NewLine,
                                            "2 tbsp chili powder", Environment.NewLine,
                                            "1 tsp cumin", Environment.NewLine,
                                            "½ tsp cayenne pepper", Environment.NewLine,
                                            "2 tbsp garlic powder", Environment.NewLine,
                                            "2 tbsp dried thyme", Environment.NewLine,
                                            "2 cup smoky BBQ sauce, plus additional for dipping", Environment.NewLine,
                                            "salt and pepper"),
                Directions = string.Concat("1. Starting at least 8 hours in advance, smother ribs with the dry ingredients: paprika, chili powder, cumin, cayenne pepper, garlic powder, dried thyme, salt and pepper. Cover and refrigerate for at least for 4 hours and up to 24 hours.", Environment.NewLine,
                                           "2. Preheat the oven to 300ºF. Arrange the ribs in a single layer in a baking sheet. Smother with BBQ sauce on both sides and add 1/4 inch of water to the bottom of the baking sheet. Cover with tin foil and slow roast for 3.5-4 hours until tender. Remove from the oven and uncover.", Environment.NewLine,
                                           "3. Preheat the broiler to high. Brush the ribs with extra BBQ sauce and broil until slightly charred, about 2 minutes.", Environment.NewLine,
                                           "4. Cut ribs and serve with additional BBQ for dipping."
                ),
                PrepTime = 15,
                TotalTime = 255,
                Serves = 6,
                ImageSource = prefix + "StLouisStylePorkRibs.jpg"
            });

            _returnRecipes.Add(new BBQRecipe
            {
                Name = "How to Cook Perfect BBQ Vegetables",
                ShortDesc = "With only five vegetables needed, and three simple pantry items, this will become your go-to recipe for the entire warm-weather season!",
                Ingredients = string.Concat("1 red bell pepper, seeded and cut into 2-inch pieces", Environment.NewLine,
                                            "1 zucchini, sliced into 3/4-inch rounds, then in quarters", Environment.NewLine,
                                            "1 red onion, cut into 3/4-inch rounds", Environment.NewLine,
                                            "1 yellow squash, cut diagonally into 1/2-inch slices", Environment.NewLine,
                                            "1 bunch (1-pound) asparagus, trimmed", Environment.NewLine,
                                            "2 Tbs olive oil", Environment.NewLine,
                                            "Coarse sea salt and freshly ground black pepper"),
                Directions = string.Concat("1. Set grill on high and lightly oil grates. Insert skewers through red bell pepper pieces, zucchini slices, and horizontally through onion slices.", Environment.NewLine,
                                           "2. Place prepared skewers, squash slices and asparagus on baking sheet. Drizzle with oil, and season with salt and pepper.", Environment.NewLine,
                                           "3. Remove from baking sheet and arrange on grill. Cook, turning occasionally until lightly brown and tender, 8-12 minutes for skewers, 4-8 minutes for asparagus and squash.", Environment.NewLine,
                                            "4. Remove skewers and serve."
                 ),
                PrepTime = 0,
                TotalTime = 0,
                Serves = 2,
                ImageSource = prefix + "BBQveg.jpg"
            });

            _returnRecipes.Add(new BBQRecipe
            {
                Name = "Buffalo Burger with Oka Cheese",
                ShortDesc = "",
                Ingredients = string.Concat("2 ¼ lb. ground buffalo meat", Environment.NewLine,
                                            "¼ cup red onion diced", Environment.NewLine,
                                            "¼ cup sun dried cranberries chopped", Environment.NewLine,
                                            "1 tsp fresh ground pepper", Environment.NewLine,
                                            "Salt to taste", Environment.NewLine,
                                            "Olive oil for brushing", Environment.NewLine,
                                            "6 slices Oka cheese", Environment.NewLine,
                                            "6 hamburger buns", Environment.NewLine,
                                            "1 cup Store bought apple cranberry chutney", Environment.NewLine,
                                            "Optional: garnish with red onion slices, lettuce and mayonnaise"
                ),
                Directions = string.Concat("1. In a medium sized bowl mix together ground meat, onion, cranberries, salt and pepper. Knead until well combined. Form into 6 equal patties being careful to work with just the meat until it forms. Brush each side lightly with olive oil. Preheat grill to medium high (375F) (190C). Oil the grill to prevent sticking.", Environment.NewLine,
                                           "2. Place burgers on the grill and cook for 3-4 minutes per side for medium rare. Buffalo burgers should be served medium rare, as the lean meat doesn’t take well to over cooking. Flip burgers. In the last minute of cooking, top with cheese and close the lid of the barbeque. Remove burgers from grill when cheese has melted. Serve with store bought apple cranberry chutney, and garnish with red onion, lettuce and mayonnaise if desired."
                ),
                PrepTime = 0,
                TotalTime = 0,
                Serves = 6,
                ImageSource = prefix + "BuffaloBurgerwithOkaCheese.jpg"
            });

            _returnRecipes.Add(new BBQRecipe
            {
                Name = "Sirloin Beef Barbequed Kabobs",
                ShortDesc = "",
                Ingredients = string.Concat("1 lb. Sirloin steak, trimmed and cubed (500g)", Environment.NewLine,
                                            "1 red pepper", Environment.NewLine,
                                            "1 yellow pepper", Environment.NewLine,
                                            "1 green pepper", Environment.NewLine,
                                            "½ cup store bought BBQ sauce (125ml)", Environment.NewLine,
                                            "¼ tsp Five Spice powder (1ml)", Environment.NewLine,
                                            "½ cup pineapple juice (125ml)", Environment.NewLine,
                                            "24 pineapple chunks", Environment.NewLine,
                                            "salt and freshly ground pepper", Environment.NewLine,
                                            "wooden skewers"),
                Directions = string.Concat("1. Divide BBQ sauce in thirds. Reserve one third for brushing kabobs. Add Five Spice powder to one bowl and half of the pineapple juice to remaining sauce. Add meat to each bowl and marinate for 15 minutes, at room temperature.", Environment.NewLine,
                                           "2. Soak skewers in water for 15 minutes.", Environment.NewLine,
                                           "3. Heat indoor or outdoor grill to medium-high heat.", Environment.NewLine,
                                           "4. Assemble beef kebabs:", Environment.NewLine,
                                           "Kids': Thread red and yellow peppers, pineapple and beef onto skewers.", Environment.NewLine,
                                           "Adults': Thread red, yellow and green peppers and beef onto skewers.", Environment.NewLine,
                                           "5. Grill the kebabs, brushing with remaining sauce for 3-4 minutes per side, until cooked through to desired doneness. Season with salt and pepper."
                ),
                PrepTime = 0,
                TotalTime = 0,
                Serves = 6,
                ImageSource = prefix + "SurfNTurfKebabs.jpg"
            });

            _returnRecipes.Add(new BBQRecipe
            {
                Name = "Shrimp and Scallop Kabobs",
                ShortDesc = "",
                Ingredients = string.Concat("14 oz small scallops (400g)", Environment.NewLine,
                                            "¾ lb. medium raw shrimp, peeled and cleaned (375g)", Environment.NewLine,
                                            "3 green onions", Environment.NewLine,
                                            "1 tsp grated lime rind (5ml)", Environment.NewLine,
                                            "2 tbsp lime juice (30ml)", Environment.NewLine,
                                            "¼ cup canola oil (65ml)", Environment.NewLine,
                                            "½ tsp sesame oil (2ml)", Environment.NewLine,
                                            "¼ tsp lemon pepper (1ml)", Environment.NewLine,
                                            "1 tbsp chopped parsley, optional (15ml)", Environment.NewLine,
                                            "1 tbsp chopped cilantro, optional (15ml)", Environment.NewLine,
                                            "wooden skewers"),
                Directions = string.Concat("1. Soak skewers in water for 15 minutes. Cut green onions into 2-inch lengths.", Environment.NewLine,
                                           "2. Thread shrimp and scallops, alternating with green onion onto soaked wooden skewers.", Environment.NewLine,
                                           "3. In small bowls mix:", Environment.NewLine,
                                           "4. Heat indoor or outdoor grill to medium-high heat.", Environment.NewLine,
                                           "5. Place kebabs on heated grill; brush with sauces and cook for 2-3 minutes per side, until cooked through. Season with salt and pepper.", Environment.NewLine,
                                           "6. Garnish with parsley and cilantro, if using."),
                PrepTime = 0,
                TotalTime = 0,
                Serves = 6,
                ImageSource = prefix + "SurfNTurfKebabs.jpg"
            });

            _returnRecipes.Add(new BBQRecipe
            {
                Name = "BBQ'd Pulled Pork Sandwiches",
                ShortDesc = "",
                Ingredients = string.Concat("1 - 6 lbs. pork butt or shoulder (2.72kg)", Environment.NewLine,
                                            "12 cups (3 litres) mesquite wood chips (8 cups soaked in cool water for 1 hour and drained)"),
                Directions = string.Concat("1. Place pork on a tray and rub the mixture into the flesh using slight pressure to tear little pockets of flavour in the meat. Place rubbed pork in a large sealable bag. Marinate in the refrigerator overnight.", Environment.NewLine,
                                           "2. Preheat barbeque to medium heat 350F (176C).", Environment.NewLine,
                                           "3. The following day, let 8 cups of wood chips soak for 1 hour in cool water. Drain wood chips. To make the smoke pouches, place 2 cups (500ml) of the drained wet chips with 1 cup (250ml) of the dry. Mix until evenly distributed. Wrap chips in foil to fit the size of your barbeque burner. Using a fork, pierce the package several times all over to allow the smoke to escape. Repeat with remaining chips to create 2 pouches in total.", Environment.NewLine,
                                           "4. Prepare barbeque for indirect cooking. Leave 2 burners off and one burner on. Place a drip pan on the side of the barbeque that is off. Place a smoking pouch on the side that is turned on, directly over the burner. Place the pork on the grill over the drip pan. Cook for 5-6 hours (about an hour a pound) changing the smoke pouch when smoke dissipates.", Environment.NewLine,
                                           "5. During the cooking mop the pork every ½ hour using a mop brush. Remove the pork from the grill and loosely cover with foil. Let rest for 30 minutes. Using your hands (rubber gloves recommended) or a fork pull at the pork meat. It will come off in threads. Serve pulled pork with reserved barbeque mop sauce and dipping sauce on soft rolls."
                ),
                PrepTime = 0,
                TotalTime = 0,
                Serves = 10,
                ImageSource = prefix + "BBQPulledPorkSandwiches.jpg"
            });

            _returnRecipes.Add(new BBQRecipe
            {
                Name = "BBQ Turkey Drumsticks with Chipotle Glaze",
                ShortDesc = "Try Chuck Hughes' delicious slow-roasted and basted BBQ turkey drumsticks, glazed with chipotle sauce.",
                Ingredients = string.Concat("Brine", Environment.NewLine,
                                            "1 cup salt (250 ml)", Environment.NewLine,
                                            "1 cup of hot water (250 ml)", Environment.NewLine,
                                            "1 cup molasses (250 ml)", Environment.NewLine,
                                            "2 lemons, sliced", Environment.NewLine,
                                            "2 onions, quartered", Environment.NewLine,
                                            "1 head of garlic, smashed", Environment.NewLine,
                                            "1 large bunch of rosemary", Environment.NewLine,
                                            "1 tbsp black peppercorns (15 ml)", Environment.NewLine,
                                            "8 cup cold water (2 l)", Environment.NewLine,
                                            "8 turkey drumsticks", Environment.NewLine,
                                            "Melted butter", Environment.NewLine,
                                            "Salt and pepper", Environment.NewLine,
                                            "Chipotle Glaze", Environment.NewLine,
                                            "Pureed chipotle in adobo sauce, store-bought"
                                            ),
                Directions = string.Concat("Brine", Environment.NewLine,
                                           "1. Pour the hot water in a large and deep non-reactive pan, bucket or large cooler, stir in the salt and molasses until fully dissolved, and then add the lemon, onions garlic, rosemary and peppercorns.", Environment.NewLine,
                                           "2. Remove the turkey from the brine and dry thoroughly. Season with salt and pepper.", Environment.NewLine,
                                           "Chipotle Glaze Roasting", Environment.NewLine,
                                           "1. Prepare your barbecue for indirect grilling by placing about 10 to 12 charcoal briquettes on only one side of the barbecue. Once the barbecue reaches 400 F (200 C), place the turkey drumsticks on the grill on the opposite side of the briquettes.", Environment.NewLine,
                                           "2. Brush with melted butter and close the lid of your barbecue.", Environment.NewLine,
                                           "3. Turn and baste the drumsticks every half hour with melted butter. Roast the drumsticks for about 2 hours or until it reaches 160 F (75 C) on a meat thermometer.", Environment.NewLine,
                                           "4. For serving: Brush the drumstick with puréed chipotle adobo sauce, store-bought."
                                           ),
                PrepTime = 15,
                TotalTime = 135,
                Serves = 8,
                ImageSource = prefix + "BBQTurkeyDrumstickswithChipotleGlaze.jpg"
            });

            _returnRecipes.Add(new BBQRecipe
            {
                Name = "Korean BBQ Short Ribs",
                ShortDesc = "Fire up the grill for these delectable Korean-style short ribs.",
                Ingredients = string.Concat("½ cup (125 mL) green onions, finely sliced", Environment.NewLine,
                                            "3/10 cup (80 mL) lime juice", Environment.NewLine,
                                            "¼ cup (60 mL) VH® Soya Sauce", Environment.NewLine,
                                            "1 jar (355 mL) VH® Korean BBQ Stir-Fry Sauce", Environment.NewLine,
                                            "2 ½ lb. (1.2 kg) Korean-style beef short ribs", Environment.NewLine,
                                            "PAM® Grilling Spray"
                ),
                Directions = string.Concat("1. Place green onions, lime juice, VH® Soya Sauce, 1 cup (250 mL) VH® Korean BBQ Stir-Fry Sauce and ribs in a large re-sealable plastic freezer bag. Seal and massage marinade into beef to cover completely.", Environment.NewLine,
                                           "2. Marinate beef in refrigerator for a least 8 hours, but preferably overnight.", Environment.NewLine,
                                           "3. Spray grill with PAM® Grilling Spray and heat to high. Remove ribs from bag and discard marinade.", Environment.NewLine,
                                           "4. Place ribs on grill and cook for 3 minutes and until beef is seared with grill marks. Turn meat over and continue to grill on the second side while basting generously with remaining sauce, another 3 minutes. Remove from the grill and serve immediately."
                                           ),
                PrepTime = 5,
                TotalTime = 15,
                Serves = 4,
                ImageSource = prefix + "KoreanBBQShortRibs.jpg"
            });

            App.IsDataLoaded = true;

            App.dbRecipes = _returnRecipes;

        }

    }
}
