// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Quantum.Models
{
    /// <summary> Provisioning status field. </summary>
    public readonly partial struct Status : IEquatable<Status>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Status"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Status(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string LaunchingValue = "Launching";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string DeletedValue = "Deleted";
        private const string FailedValue = "Failed";

        /// <summary> Succeeded. </summary>
        public static Status Succeeded { get; } = new Status(SucceededValue);
        /// <summary> Launching. </summary>
        public static Status Launching { get; } = new Status(LaunchingValue);
        /// <summary> Updating. </summary>
        public static Status Updating { get; } = new Status(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static Status Deleting { get; } = new Status(DeletingValue);
        /// <summary> Deleted. </summary>
        public static Status Deleted { get; } = new Status(DeletedValue);
        /// <summary> Failed. </summary>
        public static Status Failed { get; } = new Status(FailedValue);
        /// <summary> Determines if two <see cref="Status"/> values are the same. </summary>
        public static bool operator ==(Status left, Status right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Status"/> values are not the same. </summary>
        public static bool operator !=(Status left, Status right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Status"/>. </summary>
        public static implicit operator Status(string value) => new Status(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Status other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Status other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
