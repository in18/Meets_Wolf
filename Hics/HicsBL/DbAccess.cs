﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HicsBL
{
    public class DbAccess
    {
        /// <summary>
        /// PSP 1.1
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="lampadress"></param>
        /// <param name="lampname"></param>
        static void addLamp(string username, string password, string lampadress, string lampname)
        {
            //Übergebenes Passwort hashen und in Var pwhash speichern für Übergabe an DB
            string pwhash = HelperClass.GetHash(password);

        }

        /// <summary>
        /// PSP 8.1
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="usernameNew"></param>
        /// <param name="passwordNew"></param>
        static void addUser(string username, string password,string usernameNew, string passwordNew)
        {
            //Übergebenes Passwort hashen und in Var pwhash speichern für Übergabe an DB
            string pwhash = HelperClass.GetHash(passwordNew);
        }
        /// <summary>
        /// PSP 3.1
        /// Löschen der Lampe anhand der LampenId
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="lampId"></param>
        /// <returns></returns>
        static bool deleteLamp(string username, string password, int lampId)
        {
            bool success = false;
            //Übergebenes Passwort hashen und in Var pwhash speichern für Übergabe an DB
            string pwhash = HelperClass.GetHash(password);

            return success;
        
        }
        /// <summary>
        /// PSP 3.2
        /// Löschen einer Lampe anhand der Lampenadresse
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="lampAdress"></param>
        /// <returns></returns>
        static bool deleteLamp(string username, string password, string lampAdress)
        {
            bool success = false;
            //Übergebenes Passwort hashen und in Var pwhash speichern für Übergabe an DB
            string pwhash = HelperClass.GetHash(password);

            return success;

        }
        /// <summary>
        /// PSP 2.1
        /// Editieren eines Lampennamens anhand des alten Lampennamens
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="lampNameOld"></param>
        /// <param name="lampNameNew"></param>
        /// <returns></returns>
        static bool editLampName(string username, string password, string lampNameOld, string lampNameNew)
        {
            bool success = false;
            //Übergebenes Passwort hashen und in Var pwhash speichern für Übergabe an DB
            string pwhash = HelperClass.GetHash(password);

            return success;
        }
        /// <summary>
        /// PSP 5.1
        /// Lampe einer Gruppe anhand groupId und lampId hinzufügen
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="groupId"></param>
        /// <param name="lampId"></param>
        static bool addLampToGroup(string username, string password, int groupId, int lampId)
        {
            bool success = false;
            //Übergebenes Passwort hashen und in Var pwhash speichern für Übergabe an DB
            string pwhash = HelperClass.GetHash(password);

            return success;
        }
        /// <summary>
        /// PSP 5.3
        /// Lampe einer Gruppe anhand groupName und lampId hinzufügen
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="groupId"></param>
        /// <param name="lampId"></param>
        static bool addLampToGroup(string username, string password, string groupName, int lampId)
        {
            bool success = false;
            //Übergebenes Passwort hashen und in Var pwhash speichern für Übergabe an DB
            string pwhash = HelperClass.GetHash(password);

            return success;
        }

        /// <summary>
        /// PSP 6.1
        /// Entfernt eine Lampe von einer Gruppe mittels group_id und lamp_id
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="group_id"></param>
        /// <param name="lamp_id"></param>
        /// <returns></returns>
        static bool RemoveLampFromGroup(string username, string password, int group_id, int lamp_id)
        {
            bool success = false;

            return success;
        }
    }
}
