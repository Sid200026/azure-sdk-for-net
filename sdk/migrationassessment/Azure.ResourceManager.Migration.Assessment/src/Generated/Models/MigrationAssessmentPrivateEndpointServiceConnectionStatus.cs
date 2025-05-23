// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Migration.Assessment.Models
{
    /// <summary> The private endpoint connection status. </summary>
    public readonly partial struct MigrationAssessmentPrivateEndpointServiceConnectionStatus : IEquatable<MigrationAssessmentPrivateEndpointServiceConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MigrationAssessmentPrivateEndpointServiceConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MigrationAssessmentPrivateEndpointServiceConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";

        /// <summary> Pending. </summary>
        public static MigrationAssessmentPrivateEndpointServiceConnectionStatus Pending { get; } = new MigrationAssessmentPrivateEndpointServiceConnectionStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static MigrationAssessmentPrivateEndpointServiceConnectionStatus Approved { get; } = new MigrationAssessmentPrivateEndpointServiceConnectionStatus(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static MigrationAssessmentPrivateEndpointServiceConnectionStatus Rejected { get; } = new MigrationAssessmentPrivateEndpointServiceConnectionStatus(RejectedValue);
        /// <summary> Determines if two <see cref="MigrationAssessmentPrivateEndpointServiceConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(MigrationAssessmentPrivateEndpointServiceConnectionStatus left, MigrationAssessmentPrivateEndpointServiceConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MigrationAssessmentPrivateEndpointServiceConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(MigrationAssessmentPrivateEndpointServiceConnectionStatus left, MigrationAssessmentPrivateEndpointServiceConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MigrationAssessmentPrivateEndpointServiceConnectionStatus"/>. </summary>
        public static implicit operator MigrationAssessmentPrivateEndpointServiceConnectionStatus(string value) => new MigrationAssessmentPrivateEndpointServiceConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MigrationAssessmentPrivateEndpointServiceConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MigrationAssessmentPrivateEndpointServiceConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
