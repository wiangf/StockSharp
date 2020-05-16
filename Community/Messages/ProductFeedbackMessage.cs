﻿namespace StockSharp.Community.Messages
{
	using System;
	using System.Runtime.Serialization;

	using Ecng.Common;

	using StockSharp.Messages;

	/// <summary>
	/// Product feedback message.
	/// </summary>
	public class ProductFeedbackMessage : Message, IOriginalTransactionIdMessage
	{
		/// <inheritdoc />
		[DataMember]
		public long OriginalTransactionId { get; set; }

		/// <summary>
		/// Identifier.
		/// </summary>
		[DataMember]
		public long Id { get; set; }

		/// <summary>
		/// Text.
		/// </summary>
		[DataMember]
		public string Text { get; set; }

		/// <summary>
		/// Text.
		/// </summary>
		[DataMember]
		public long Author { get; set; }

		/// <summary>
		/// Rating.
		/// </summary>
		[DataMember]
		public decimal Rating { get; set; }

		/// <summary>
		/// Rating.
		/// </summary>
		[DataMember]
		public DateTimeOffset CreationDate { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ProductFeedbackMessage"/>.
		/// </summary>
		public ProductFeedbackMessage()
			: base(CommunityMessageTypes.ProductFeedback)
		{
		}

		/// <summary>
		/// Create a copy of <see cref="ProductFeedbackMessage"/>.
		/// </summary>
		/// <returns>Copy.</returns>
		public override Message Clone()
		{
			var clone = new ProductFeedbackMessage
			{
				OriginalTransactionId = OriginalTransactionId,
				Id = Id,
				Text = Text,
				Author = Author,
				Rating = Rating,
				CreationDate = CreationDate,
			};
			CopyTo(clone);
			return clone;
		}

		/// <inheritdoc />
		public override string ToString()
		{
			var str = base.ToString() + $",OrigTrId={OriginalTransactionId}";

			if (Id != 0)
				str += $",Id={Id}";

			if (!Text.IsEmpty())
				str += $",Text={Text}";

			if (Author != 0)
				str += $",Author={Author}";

			if (Rating != 0)
				str += $",Rating={Rating}";

			if (CreationDate != default)
				str += $",Created={CreationDate}";

			return str;
		}
	}
}