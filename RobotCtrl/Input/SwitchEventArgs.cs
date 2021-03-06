﻿using System;

namespace Hslu.Csa.Team6.RobotCtrl
{

    /// <summary>
    /// EventArgs-Klasse um über Änderungen der Schalter zu informieren.
    /// </summary>
    public class SwitchEventArgs : EventArgs
    {

        #region constructor & destructor
        /// <summary>
        /// Initialisiert die SwitchEventArgs-Klasse
        /// </summary>
        /// <param name="swi">der betroffene Schalter</param>
        /// <param name="switchEnabled">der aktuelle Zustand des Schalters</param>
        public SwitchEventArgs(Switches swi, bool switchEnabled)
        {
            Swi = swi;
            SwitchEnabled = switchEnabled;
        }
        #endregion


        #region properties
        /// <summary>
        /// Liefert bzw. setzt die Eigenschaft, ob der Schalter aktiviert ist oder nicht
        /// </summary>
        public bool SwitchEnabled { get; set; }


        /// <summary>
        /// Liefert bzw. setzt den betroffenen Schalter
        /// </summary>
        public Switches Swi { get; set; }
        #endregion
    }
}
