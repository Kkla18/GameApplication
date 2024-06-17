﻿using GameApplication.Models;
using GameApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace GameApplication.Controllers
{
    public class ButtonController : Controller
    {
        //List of buttons // WE ARE HERE TO TEST THIS................................
        static List<ButtonModel> buttons = new List<ButtonModel>();
        Random random = new Random();
        const int GRID_SIZE = 9;
        public IActionResult Index()
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
        public IActionResult HandleButtonClick(string buttonNumber)
        {
            //converting from string to int
            int bN = int.Parse(buttonNumber);

            //adding one to the button state. If greater than 4, reset to 0.
            buttons.ElementAt(bN).ButtonState = (buttons.ElementAt(bN).ButtonState + 1) % 3;

            //re-display the buttons
            return View("Index", buttons);
        }

        public IActionResult ShowOneButton(int buttonNumber)
        {
            //add one to the button state. If greater than 2, reset to 0
            buttons.ElementAt(buttonNumber).ButtonState = (buttons.ElementAt(buttonNumber).ButtonState + 1) % 3;

            //re-display the button that was clicked
            return PartialView(buttons.ElementAt(buttonNumber));

        }

        public IActionResult RightClickShowOneButton(int buttonNumber)
        {
            //sets button state to the flag.
            buttons.ElementAt(buttonNumber).ButtonState = 3;


            //re-display the button that was clicked
            return PartialView("ShowOneButton", buttons.ElementAt(buttonNumber));
        }

        public IActionResult ProcessSave(UserModel user)
        {
            
            SecurityService securityService = new SecurityService();

            if (securityService.IsValid(user))
            {
                user.ButtonLists.Add(buttons);
                // int index = user.ButtonLists.IndexOf(buttons);

            }



            return View("DefaultSavedGames", user);
        }
    }
}
