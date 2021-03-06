// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.EntityFrameworkCore.TestModels.TransportationModel
{
    public class FuelTank
    {
        public string VehicleName { get; set; }
        public string FuelType { get; set; }

        public string Capacity { get; set; }

        // #9005
        //public PoweredVehicle Vehicle { get; set; }
        public CombustionEngine Engine { get; set; }

        public override bool Equals(object obj)
            => obj is FuelTank other
               && VehicleName == other.VehicleName
               && FuelType == other.FuelType
               && Capacity == other.Capacity;

        public override int GetHashCode()
            => (VehicleName.GetHashCode() * 397
                ^ FuelType.GetHashCode()) * 397
               ^ Capacity.GetHashCode();
    }
}
