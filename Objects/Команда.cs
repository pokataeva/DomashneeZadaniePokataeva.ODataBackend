﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Domashnee_zadanie_Pokataeva
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    //  *** Start programmer edit section *** (Using statements)

    //  *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Команда.
    /// </summary>
    //  *** Start programmer edit section *** (Команда CustomAttributes)

    //  *** End programmer edit section *** (Команда CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("КомандаE", new string[] {
            "Название as \'Название\'"})]
    [View("КомандаL", new string[] {
            "Название as \'Название\'"})]
    public class Команда : ICSSoft.STORMNET.DataObject
    {
        
        private string fНазвание;
        
        //  *** Start programmer edit section *** (Команда CustomMembers)

        //  *** End programmer edit section *** (Команда CustomMembers)

        
        /// <summary>
        /// Название.
        /// </summary>
        //  *** Start programmer edit section *** (Команда.Название CustomAttributes)

        //  *** End programmer edit section *** (Команда.Название CustomAttributes)
        [StrLen(255)]
        public virtual string Название
        {
            get
            {
                //  *** Start programmer edit section *** (Команда.Название Get start)

                //  *** End programmer edit section *** (Команда.Название Get start)
                string result = this.fНазвание;
                //  *** Start programmer edit section *** (Команда.Название Get end)

                //  *** End programmer edit section *** (Команда.Название Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Команда.Название Set start)

                //  *** End programmer edit section *** (Команда.Название Set start)
                this.fНазвание = value;
                //  *** Start programmer edit section *** (Команда.Название Set end)

                //  *** End programmer edit section *** (Команда.Название Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "КомандаE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View КомандаE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("КомандаE", typeof(IIS.Domashnee_zadanie_Pokataeva.Команда));
                }
            }
            
            /// <summary>
            /// "КомандаL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View КомандаL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("КомандаL", typeof(IIS.Domashnee_zadanie_Pokataeva.Команда));
                }
            }
        }
    }
}
