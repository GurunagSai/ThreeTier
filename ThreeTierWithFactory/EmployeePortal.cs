using BusinessLayer;
using DomainLayer;
using DomainLayer.Enum;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ThreeTierWithFactory
{
    class EmployeePortal
    {
        private  IRegistrationModel _authenticationModel;
        private  IFactory _portalFactory;

        /// <summary>
        /// switch control to user
        /// </summary>
        public void UserControl()
        {
            int option = 0;
            while (option != 3)
            {

                Console.WriteLine(StringLiterals.UserChoice);
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            LoginOption();
                            break;
                        }

                    case 2:
                        {
                            RegistrationOption();
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine(StringLiterals.Exit);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine(StringLiterals.WrongOption);
                            break;
                        }
                }
            }
        }

        /// <summary>
        /// Login Credintals
        /// </summary>
        private void LoginOption()
        {

            Console.WriteLine(StringLiterals.Login + StringLiterals.EmailId);
            string emailId = Console.ReadLine();
            Console.WriteLine(StringLiterals.Password);
            string password = Console.ReadLine();
            _portalFactory = new AuthenticationFactory(emailId, password);
            _authenticationModel = _portalFactory.GetModel(UserOptionEnum.Login);
            string access = _authenticationModel.ValidateLogin();

            if (access == StringLiterals.LoginSuccessful)
            {
                Console.WriteLine(access);
                DisplayControl();
            }
            else
            {
                Console.WriteLine(access);
            }
        }

        /// <summary>
        /// Registration of a new user
        /// </summary>
        private void RegistrationOption()
        {
            Console.WriteLine(StringLiterals.Registration + StringLiterals.EmailId);
            string emailId = Console.ReadLine();

            Console.WriteLine(StringLiterals.ValidPassword);
            string password = Console.ReadLine();

            Console.WriteLine(StringLiterals.ConfirmPassword);
            string confirmPassword = Console.ReadLine();

            Console.WriteLine(StringLiterals.FirstName);
            string firstName = Console.ReadLine();

            Console.WriteLine(StringLiterals.LastName);
            string lastName = Console.ReadLine();

            Console.WriteLine(StringLiterals.IsStudent);
            string temp = Console.ReadLine();
            bool isStudent;
            if (temp=="yes")
            {
                 isStudent = true;
            }
            else
            {
                 isStudent = false;
            }

            if (Validations.ValidateEmail(emailId)
                && Validations.ValidatePassword(password)
                && Validations.VerifyPassword(password, confirmPassword)
                && Validations.ValidateName(firstName) && Validations.ValidateName(lastName))
            {
                _portalFactory = new AuthenticationFactory(emailId, password,confirmPassword,firstName,lastName,isStudent);
                _authenticationModel = _portalFactory.GetModel(UserOptionEnum.Registration);
                Console.WriteLine(_authenticationModel.Register());
            }
            else
            {
                Console.WriteLine(StringLiterals.InvalidDetails);
            }
        }

        /// <summary>
        /// if you are logged in then you can have control over the data in the list
        /// </summary>
        private void DisplayControl()
        {
            int displayOption = 0;
            while (displayOption != 4)
            {
                Console.WriteLine(StringLiterals.DisplayControl);
                displayOption = int.Parse(Console.ReadLine());
                switch (displayOption)
                {
                    case 1:
                        {
                            DataRead(UserChoiceEnum.Student);
                            break;
                        }

                    case 2:
                        {
                            DataRead(UserChoiceEnum.Other);
                            break;
                        }

                    case 3:
                        {
                            DataRead(UserChoiceEnum.All);
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine(StringLiterals.LogOutSuccessful);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine(StringLiterals.WrongOption);
                            break;
                        }

                }
            }

        }

        /// <summary>
        /// Displays the data of particular option
        /// </summary>
        /// <param name="op"></param>
        private void DataRead(UserChoiceEnum op)
        {
            UserBusiness userBusiness = new UserBusiness();
            Console.WriteLine(StringLiterals.TableData);
            foreach (var userData in userBusiness.GetUserDetails(op))
            {
                Console.WriteLine("{0}\t{1} {2}\t{3}", userData.EmailId, userData.FirstName, userData.LastName, userData.IsStudent);
            }
            userBusiness.GetUserDetails(op);
            
        }
    }
}
