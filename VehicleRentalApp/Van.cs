﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VehicleRentalApp
{
    public class Van : Vehicle
    {
        private float _LoadCapacity;
        private float _IntLength;
        private float _IntWidth;
        private float _IntHeight;
        private float _Volume;

        [JsonConstructor]
        public Van() { }
        public Van(string make, string model, int yr, decimal rate, string trans, int numSeats, string fuel, float lC, float len, float wid, float hei)
        {
            _Make = make;
            _Model = model;
            _Year = yr;
            _DailyRate = rate;
            _Transmission = trans;
            _SeatCapacity = numSeats;
            _FuelType = fuel;
            _LoadCapacity = lC;
            _IntLength = len;
            _IntWidth = wid;
            _IntHeight = hei;
            _Volume = _IntLength * _IntWidth * _IntHeight;
            Status = "Available";
            SetType();
        }
        public override void SetType() { _TypeOfVehicle = "Van"; }
        [JsonInclude]
        public override float? LoadCapacity
        {
            get { return _LoadCapacity; }
            set { _LoadCapacity = value ?? 0; }
        }
        [JsonInclude]
        public override float? IntLength
        {
            get { return _IntLength; }
            set { _IntLength = value ?? 0; }
        }
        [JsonInclude]
        public override float? IntWidth
        {
            get { return _IntWidth; }
            set { _IntWidth = value ?? 0; }
        }
        [JsonInclude]
        public override float? IntHeight
        {
            get { return _IntHeight; }
            set { _IntHeight = value ?? 0; }
        }
        [JsonInclude]
        public override float? Volume
        {
            get { return _Volume; }
            set { _Volume = value ?? 0; }
        }
        public override string? GetLWH() { return $"{_IntLength}m x {_IntWidth}m x {_IntHeight}m"; }
        public override string ToFile()
        {
            return $"{_TypeOfVehicle}, {_Make}, {_Model}, {_Year}, {_DailyRate}, {_Transmission}, {_SeatCapacity}, {_FuelType}, {_Status}, {_LoadCapacity}, {_IntLength}, {_IntWidth}, {_IntHeight}, {_Volume}";
        }
    }
}
