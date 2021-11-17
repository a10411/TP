/*
*	<copyright file="Classes.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>nfrv9</author>
*   <date>11/6/2021 3:18:06 PM</date>
*	<description></description>
**/
using System;
using System.Collections;

namespace Classes
{   
    
   
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
        public enum Type { LAND, APRTMNT, HOUSE }; // Type of Property
        public enum State { FS, NFS }; // State of Property: For Sale, Not For Sale (adquired, or simply nfs) 
        Type t;
        static int totalRS;
        DateTime aquisitionDate;



        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public RealState()
        {
            aquisitionDate = DateTime.Today;
            t = Type.LAND;
            totalRS++;
        }

        public RealState(Type t, DateTime d, Decimal p)
        {
            this.t = t;
            aquisitionDate = d;
 
        }
        #endregion

        #region Properties

        public Type T
        {
            get { return t; }
            set { t = value; }
        }

        public DateTime ConstructionYear
        {
            get { return aquisitionDate; }
            set { aquisitionDate = value; }
        }

        public int TotalRS
        {
            get { return totalRS; }
        }

       
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
