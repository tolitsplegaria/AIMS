﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AIMS.Models.Tables
{
    public class TableRequestItem : TableBasedModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RequestItemID { get; set; }

        public int RequestID { get; set; }
        public int InventoryItemID { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

    }
}