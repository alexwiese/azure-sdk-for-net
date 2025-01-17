// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.OpenAI
{
    /// <summary>
    /// An abstract representation of structured information about why a chat completions response terminated.
    /// Please note <see cref="ChatFinishDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="StopFinishDetails"/> and <see cref="MaxTokensFinishDetails"/>.
    /// </summary>
    public abstract partial class ChatFinishDetails
    {
        /// <summary> Initializes a new instance of <see cref="ChatFinishDetails"/>. </summary>
        protected ChatFinishDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ChatFinishDetails"/>. </summary>
        /// <param name="type"> The object type. </param>
        internal ChatFinishDetails(string type)
        {
            Type = type;
        }

        /// <summary> The object type. </summary>
        internal string Type { get; set; }
    }
}
