namespace Drupal8Rest


{
    public class Drupal8NodeBase
    {
        public Dp8ValueField[] nid { get; set; }
        public Dp8ValueField[] uuid { get; set; }
        public Dp8ValueField[] vid { get; set; }
        public Dp8ValueField[] langcode { get; set; }
        public Dp8Target[] type { get; set; }
        public Dp8DataValueField[] revision_timestamp { get; set; }
        public Dp8Target[] revision_uid { get; set; }
        public Dp8Target[] url { get; set; }
        public Dp8ValueField[] status { get; set; }
        public Dp8ValueField[] title { get; set; }
        public Dp8Target[] uid { get; set; }
        public Dp8DataValueField[] created { get; set; }
        public Dp8DataValueField[] changed { get; set; }
        public Dp8ValueField[] promote { get; set; }
        public Dp8ValueField[] sticky { get; set; }
        public Dp8ValueField[] default_langcode { get; set; }
        public Dp8ValueField[] revision_translation_affected { get; set; }
        public Dp8PathField[] path { get; set; }
        public Dp8ValueField[] content_translation_source { get; set; }
        public Dp8ValueField[] content_translation_outdated { get; set; }
        public Dp8TextValueField[] body { get; set; }
        public Dp8Target[] field_domain_access { get; set; }
        public Dp8ValueField[] field_domain_all_affiliates { get; set; }
        public Dp8MetatagValueField metatag { get; set; }

    }
}
