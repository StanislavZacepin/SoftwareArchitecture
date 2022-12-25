namespace SoftwareArchitecture.Dz3.Interfaces
{
    /// <summary>
    /// протирка лобового стикла,фары,зеркала
    /// </summary>
    public interface iWipe
    {
        /// <summary>
        /// протирка лобового стикла
        /// </summary>
        void wipWindshield();

        /// <summary>
        /// протирка фары
        /// </summary>
        void wipHeadLight();

        /// <summary>
        ///  протирка зеркал
        /// </summary>
        void wipMirrors();
    }
}
