namespace Server.Items
{
    public class StoneFireplaceEastAddon : BaseAddon
    {
        [Constructible]
        public StoneFireplaceEastAddon()
        {
            AddComponent(new AddonComponent(0x959), 0, 0, 0);
            AddComponent(new AddonComponent(0x953), 0, 1, 0);
        }

        public StoneFireplaceEastAddon(Serial serial) : base(serial)
        {
        }

        public override BaseAddonDeed Deed => new StoneFireplaceEastDeed();

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

    public class StoneFireplaceEastDeed : BaseAddonDeed
    {
        [Constructible]
        public StoneFireplaceEastDeed()
        {
        }

        public StoneFireplaceEastDeed(Serial serial) : base(serial)
        {
        }

        public override BaseAddon Addon => new StoneFireplaceEastAddon();
        public override int LabelNumber => 1061848; // stone fireplace (east)

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
