﻿namespace VisualPlus.Delegates
{
    #region Namespace

    using VisualPlus.EventArgs;

    #endregion

    public delegate void BorderColorChangedEventHandler(ColorEventArgs e);

    public delegate void BorderRoundingChangedEventHandler();

    public delegate void BorderThicknessChangedEventHandler();

    public delegate void BorderTypeChangedEventHandler();

    public delegate void BorderVisibleChangedEventHandler();

    public delegate void BorderHoverVisibleChangedEventHandler();

    public delegate void BorderHoverColorChangedEventHandler(ColorEventArgs e);
}