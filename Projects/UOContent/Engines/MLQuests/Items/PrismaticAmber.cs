namespace Server.Items
{
    public class PrismaticAmber : Amber
    {
        [Constructible]
        public PrismaticAmber()
        {
        }

        public PrismaticAmber(Serial serial) : base(serial)
        {
        }

        public override int LabelNumber => 1075299; // Prismatic Amber

        public override void AddNameProperties(ObjectPropertyList list)
        {
            base.AddNameProperties(list);

            list.Add(1075269); // Destroyed when dropped
        }

        public override bool DropToWorld(Mobile from, Point3D p)
        {
            var ret = base.DropToWorld(from, p);

            if (ret)
            {
                DestroyItem(@from);
            }

            return ret;
        }

        public override bool DropToMobile(Mobile from, Mobile target, Point3D p)
        {
            var ret = base.DropToMobile(from, target, p);

            if (ret)
            {
                DestroyItem(@from);
            }

            return ret;
        }

        public override bool DropToItem(Mobile from, Item target, Point3D p)
        {
            var ret = base.DropToItem(from, target, p);

            if (ret && Parent != from.Backpack)
            {
                DestroyItem(@from);
            }

            return ret;
        }

        public virtual void DestroyItem(Mobile from)
        {
            from.SendLocalizedMessage(500424); // You destroyed the item.
            Delete();
        }

        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0); // version
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);

            var version = reader.ReadInt();
        }
    }
}
