using GameApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ButtonAPIController : ControllerBase
    {
        //List of List of Buttons
        static List<List<ButtonModel>> ButtonList = new List<List<ButtonModel>>();
        //List of Buttons 
        static List<ButtonModel> buttons = new List<ButtonModel>();
        Random random = new Random();
        const int GRID_SIZE = 9;

        [HttpGet]
        public ActionResult <IEnumerable<ButtonModel>> Index()
        {
            //New list when page loads
            buttons = new List<ButtonModel>();

            //Generating new buttons to randomly choose button colors.
            for (int i = 0; i < GRID_SIZE; i++)
            {
                buttons.Add(new ButtonModel(i, random.Next(3)));
            }

            //sending the button list to the view
            return View("Index", buttons);
        }
        [HttpPut("HandleButtonClick")]
        public ActionResult <ButtonModel> HandleButtonClick(string buttonNumber)
        {
            //converting from string to int
            int bN = int.Parse(buttonNumber);

            //adding one to the button state. If greater than 4, reset to 0.
            buttons.ElementAt(bN).ButtonState = (buttons.ElementAt(bN).ButtonState + 1) % 3;

            //re-display the buttons
            return View("Index", buttons);
        }

        [HttpPut("ShowOneButton")]
        public ActionResult <ButtonModel> ShowOneButton(int buttonNumber)
        {
            //add one to the button state. If greater than 2, reset to 0
            buttons.ElementAt(buttonNumber).ButtonState = (buttons.ElementAt(buttonNumber).ButtonState + 1) % 3;

            //re-display the button that was clicked
            return PartialView(buttons.ElementAt(buttonNumber));

        }

        [HttpPut("rightclickshowonebutton")]
        public ActionResult <ButtonModel> RightClickShowOneButton(int buttonNumber)
        {
            //sets button state to the flag.
            buttons.ElementAt(buttonNumber).ButtonState = 3;


            //re-display the button that was clicked
            return PartialView("ShowOneButton", buttons.ElementAt(buttonNumber));
        }

        [HttpPut("SaveGame")]
        public ActionResult <ButtonModel> SaveGame()
        {
            ButtonList.Add(buttons);

            return View("SavedGames", ButtonList);
        }

        [HttpPut("DeleteGame")]
        public ActionResult <ButtonModel> DeleteGame(int i)
        {
            ButtonList.RemoveAt(i);

            return View("SavedGames", ButtonList);
        }

        [HttpPut("LoadGame")]
        public ActionResult <ButtonModel> LoadGame(int i)
        {
            buttons = ButtonList.ElementAt(i);

            return View("Index", buttons);

        }
    }
}
