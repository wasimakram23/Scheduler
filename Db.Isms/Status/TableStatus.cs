/*
 * CR Title         : Isms sprint-3
 * Start Date       : 21-Feb-2019
 * Version          : 1.0
 * Author/Developer : dipon
 * Purpose          : table status class
*/

namespace Db.Isms.Status
{

    //public enum RequestStage
    //{
    //    Open = 1,
    //    AutoClosed = 2,             /*all sim procesed*/
    //    Postponed = 3,
    //}

    /// <summary>
    /// used in sim table
    /// </summary>
    public enum SimRequestStages
    {
        Open = 1,
        Finished = 2,               /*approved at the last stage*/
        Rejected = -3,              /*rejected at any stage*/
        Postponed = -4,
    }

    public enum ActivationSimApprovalLevel
    {
        RejectedBySsm = -2,
        None = 0,
        RequestFromCustomer = 1,
        ApprovedBySsm = 2,
    }

    public enum TimeLimitSimApprovalLevel
    {
        RejectedBySsm = -3,
        RejectedByHod = -2,
        None = 0,
        RequestFromCustomer = 1,
        ApprovedByHod = 2,
        ApprovedBySsm = 3,
    }

    public enum CreditLimitSimApprovalLevel
    {
        RejectedByClg = -3,
        RejectedByHod = -2,
        None = 0,
        RequestFromCustomer = 1,
        ApprovedByHod = 2,
        ApprovedByClg = 3,
    }

    /*SIM life-cycle stages*/
    public enum SimOperations
    {
        Delivered = 1,
        Activated = 2,
        TimeLimitExtented = 3,
        CreditLimitExtented = 4
    }

    public enum EmailOutBoxDeliveryStatus
    {
        Failed = -2,
        Initial = 0,
        InProgress = 1,
        Done = 2,
    }
}
