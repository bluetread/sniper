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
        public DateTime? CreateDate { get; set; }
        public string Description { get; set; }
        public virtual DateTime? EndDate { get; set; }
        public bool IsNext { get; set; }
        public bool IsNow { get; set; }
        public bool IsPrevious { get; set; }
        public DateTime? LastCommentDate { get; set; }
        public virtual string Name { get; set; }
        public double NumericPriority { get; set; }
        public virtual DateTime? StartDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string Tags { get; set; }

        public EntityType EntityType { get; set; }
        public GeneralUser LastCommentedUser { get; set; }
        public GeneralUser LastEditor { get; set; }
        public TestPlan LinkedTestPlan { get; set; }
        public GeneralUser Owner { get; set; }
        public virtual Project Project { get; set; }

        public Collection<Attachment> Attachments { get; set; }
        public Collection<Comment> Comments { get; set; }
        public Collection<CustomField> CustomFields { get; set; }
        public Collection<GeneralFollower> Followers { get; set; }
        public Collection<InboundAssignable> InboundAssignables { get; set; }
        public Collection<Relation> MasterRelations { get; set; }
        public Collection<Message> Messages { get; set; }
        public Collection<OutboundAssignable> OutboundAssignables { get; set; }
        public Collection<Relation> SlaveRelations { get; set; }
        public Collection<Tag> TagObjects { get; set; }
#if false
        //TODO: May not need since there is a TagObjects Collection
        public Collection<string> TagList => string.IsNullOrWhiteSpace(Tags)
            ? new Collection<string>()
            : new Collection<string>((Tags.Split(',').ToList()));
#endif
    }
}