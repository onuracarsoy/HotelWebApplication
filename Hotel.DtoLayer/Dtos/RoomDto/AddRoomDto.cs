﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DtoLayer.Dtos.RoomDto
{
    public class AddRoomDto
    {

        [Required(ErrorMessage ="Lütfen oda numarasını giriniz.")]
        public string RoomNumber { get; set; }

        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Lütfen fiyat giriniz.")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Lütfen oda başlığı giriniz.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen yatak sayısı giriniz.")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Lütfen banyo sayısı giriniz.")]
        public string BathCount { get; set; }

        public string Wifi { get; set; }

        public string Descripton { get; set; }
    }
}
