/*
*	<copyright file="Classes.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>nfrv9</author>
*   <date>11/6/2021 3:17:17 PM</date>
*	<description></description>
**/
using System;

namespace Classes
{
    enum Type {APRTMNT = 1, HOUSE = 2, LAND = 3 }; // Type of Property
    enum State { FS, NFS }; // State of Property: For Sale, Not For Sale (adquired, or simply nfs)
    /// <summary>
    /// Purpose:
    /// Created by: nfrv9
    /// Created on: 11/6/2021 3:17:17 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Property
    {
        #region Attributes

        decimal value;
        decimal rent;
        string adress;
        Type type;
        State state;
        
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Property()
        {
            

        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Property()
        {
        }
        #endregion

        #endregion
    }
}
