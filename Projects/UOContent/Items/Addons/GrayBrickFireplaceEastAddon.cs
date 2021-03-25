namespace Server.Items
{
    public class GrayBrickFireplaceEastAddon : BaseAddon
    {
        [Constructible]
        public GrayBrickFireplaceEastAddon()
        {
            AddComponent(new AddonComponent(0x93D), 0, 0, 0);
            AddComponent(new AddonComponent(0x937), 0, 1, 0);
        }

        public GrayBrickFireplaceEastAddon(Serial serial) : base(serial)
        {
        }

        public override BaseAddonDeed Deed => new GrayBrickFireplaceEastDeed();

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

    public class GrayBrickFireplaceEastDeed : BaseAddonDeed
    {
        [Constructible]
        public GrayBrickFireplaceEastDeed()
        {
        }

        public GrayBrickFireplaceEastDeed(Serial serial) : base(serial)
        {
        }

        public override BaseAddon Addon => new GrayBrickFireplaceEastAddon();
        public override int LabelNumber => 1061846; // grey brick fireplace (east)

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
