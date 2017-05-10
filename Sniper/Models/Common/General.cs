using Newtonsoft.Json;
using Sniper.Application;
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
        [RequiredForCreate]
        [JsonProperty(Required = Required.DisallowNull)]
        public virtual string Name { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual DateTime? CreateDate { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual string Description { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual DateTime? EndDate { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual bool IsNext { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual bool IsNow { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual bool IsPrevious { get; internal set; }

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
        public virtual EntityType EntityType { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual GeneralUser LastCommentedUser { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual GeneralUser LastEditor { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual TestPlan LinkedTestPlan { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual GeneralUser Owner { get; set; }

        [RequiredForCreate(JsonProperties.Name, JsonProperties.EntityState)]
        [JsonProperty(Required = Required.DisallowNull)]
        public virtual Project Project { get; set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Collection<Attachment> Attachments { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Collection<Comment> Comments { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Collection<CustomField> CustomFields { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Collection<GeneralFollower> Followers { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Collection<InboundAssignable> InboundAssignables { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Collection<Relation> MasterRelations { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Collection<Message> Messages { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Collection<OutboundAssignable> OutboundAssignables { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Collection<Relation> SlaveRelations { get; internal set; }

        [JsonProperty(Required = Required.Default)]
        public virtual Collection<Tag> TagObjects { get; internal set; }
    }
}