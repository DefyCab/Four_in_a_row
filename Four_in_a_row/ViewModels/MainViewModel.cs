using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Four_in_a_row.Commands;


namespace Four_in_a_row.ViewModels
{
    public class MainViewModel
    {
        public TileViewModel Tile1 { get; } = new TileViewModel();
    }
}
