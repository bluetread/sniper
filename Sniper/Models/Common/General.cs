using Newtonsoft.Json;
using Sniper.Contracts.Entities.Common;
using System;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    [CannotCreateReadUpdateDelete]
    public class General : Entity, IHasName, IHasDescription, IHasCreateDate, IHasDateRange,
        IHasEntityType, IHasModifyDate, IHasOwner, IHasProject, IHasCustomFields,
        IHasAttachments, IHasComments, IHasFollowers, IHasMessages, IHasTags
    {
        [JsonProperty(Required = Required.DisallowNull)]
        public virtual string Name { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual DateTime? CreateDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual string Description { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual DateTime? EndDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual bool IsNext { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual bool IsNow { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual bool IsPrevious { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual DateTime? LastCommentDate { get; set; }
        
        [JsonProperty(Required = Required.Default)]
        public virtual double NumericPriority { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual DateTime? StartDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual DateTime? ModifyDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual string Tags { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual EntityType EntityType { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual GeneralUser LastCommentedUser { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual GeneralUser LastEditor { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual TestPlan LinkedTestPlan { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual GeneralUser Owner { get; set; }

        [JsonProperty(Required = Required.DisallowNull)]
        public virtual Project Project { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Collection<Attachment> Attachments { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Collection<Comment> Comments { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Collection<CustomField> CustomFields { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Collection<GeneralFollower> Followers { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Collection<InboundAssignable> InboundAssignables { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Collection<Relation> MasterRelations { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Collection<Message> Messages { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Collection<OutboundAssignable> OutboundAssignables { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Collection<Relation> SlaveRelations { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Collection<Tag> TagObjects { get; set; }
    }
}