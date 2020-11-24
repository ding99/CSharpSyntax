namespace AutoLotConsoleApp.EF {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Inventory {
        public override string ToString() {
            return $"{this.PetName?? "--No Name--"} is a {this.Color} {this.Make} with ID {this.CarId}.";
        }
    }
}