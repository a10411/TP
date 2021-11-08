/*
*	<copyright file="Classes.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>nfrv9</author>
*   <date>11/6/2021 3:18:06 PM</date>
*	<description></description>
**/
using System;

namespace Classes
{   
    
    enum Type { APRTMNT, HOUSE, LAND}; // Type of Property
    enum State {FS, NFS }; // State of Property: For Sale, Not For Sale (adquired, or simply nfs) 

    /// <summary>
    /// Purpose:
    /// Created by: nfrv9
    /// Created on: 11/6/2021 3:18:06 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class RealState
    {
        #region Attributes

        static int totalRS;
        static Property[] properties;


        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public RealState()
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
        ~RealState()
        {
        }
        #endregion

        #endregion
    }
}
