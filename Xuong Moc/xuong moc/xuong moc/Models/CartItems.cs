﻿using System;
using System.ComponentModel.DataAnnotations;

namespace xuong_moc.Models
{
    public class CartItem
    {
        public int Id { get; set; }            
        public int UserId { get; set; }            
        public int ProductId { get; set; }         
        public int Quantity { get; set; }          
        public decimal UnitPrice { get; set; }     
        public decimal TotalPrice => Quantity * UnitPrice; 
        public DateTime CreatedAt { get; set; }   
        public DateTime? UpdatedAt { get; set; }  
    }
}
