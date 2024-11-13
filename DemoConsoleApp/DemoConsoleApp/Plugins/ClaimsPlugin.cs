using Microsoft.SemanticKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApp.Plugins
{
    // Class with mock data for claim operations
    public class ClaimsPlugin
    {
        [KernelFunction("create_claim")]
        [Description("Creates claim based on the given input data")]
        [return: Description("Claim created response which generates the tracking Id as part of the response")]
        public ClaimResponseModel CreateClaim(ClaimCreateModel model)
        {
            // Logic to create a new claim
            var response = new ClaimResponseModel
            {
                TrackingID = 101,
                InitialSubmission = model.InitialSubmission,
                InformationGathering = model.InformationGathering,
                DocumentUploads = model.DocumentUploads,
                EvidenceSubmission = model.EvidenceSubmission,
                ClaimRegistration = model.ClaimRegistration
            };
            return response;
        }

        [KernelFunction("update_claim")]
        [Description("Updates claim based on the given input data model and tracking Id")]
        [return: Description("Updated Claim response")]
        public ClaimResponseModel UpdateClaim(int trackingId, ClaimUpdateModel model)
        {
            // Logic to update an existing claim
            var response = new ClaimResponseModel
            {
                TrackingID = trackingId,
                InformationVerification = model.InformationVerification,
                CrossCheckDetails = model.CrossCheckDetails,
                DiscrepancyFlagging = model.DiscrepancyFlagging,
                PolicyAssessment = model.PolicyAssessment,
                EntitlementCalculation = model.EntitlementCalculation,
                ClaimDecision = model.ClaimDecision,
                OutcomeCommunication = model.OutcomeCommunication,
                PaymentProcessing = model.PaymentProcessing,
                ClaimClosure = model.ClaimClosure,
                ClaimArchiving = model.ClaimArchiving
            };
            return response;
        }

        [KernelFunction("get_claim")]
        [Description("Gets claim data based for the given tracking Id")]
        [return: Description("Returns claim as part of the response for the given tracking Id")]
        public ClaimResponseModel GetClaim(int trackingId)
        {
            // Logic to retrieve a claim by tracking ID
            var response = new ClaimResponseModel
            {
                TrackingID = trackingId,
                InitialSubmission = "Submitted by Sirisha",
                InformationGathering = "Gathered initial information",
                DocumentUploads = "Uploaded ID and proof of address",
                EvidenceSubmission = "Submitted photos of damage",
                ClaimRegistration = "Registered claim for user",
                InformationVerification = "Verified ID and address",
                CrossCheckDetails = "Cross-checked with existing records",
                DiscrepancyFlagging = "No discrepancies found",
                PolicyAssessment = "Assessed against policy conditions",
                EntitlementCalculation = "Calculated potential payout",
                ClaimDecision = "Approved",
                OutcomeCommunication = "Informed customer of approval",
                PaymentProcessing = "Processed payment of 25,000 INR"
            };
            return response;
        }

        [KernelFunction("get_instructions")]
        [Description("Gets claim instructions")]
        [return: Description("Returns claim instructions")]
        public ClaimInstructionsModel GetClaimInstructions()
        {
            var instructions = new ClaimInstructionsModel
            {
                Step1 = "Gather all necessary documents such as ID, proof of address, and evidence of the claim.",
                Step2 = "Submit the initial claim through the online portal or by contacting the claims intake agent.",
                Step3 = "Upload all required documents and evidence to support your claim."
            };
            return instructions;
        }
    }

    public class ClaimCreateModel
    {
        public string InitialSubmission { get; set; }
        public string InformationGathering { get; set; }
        public string DocumentUploads { get; set; }
        public string EvidenceSubmission { get; set; }
        public string ClaimRegistration { get; set; }
    }

    public class ClaimUpdateModel
    {
        public string InformationVerification { get; set; }
        public string CrossCheckDetails { get; set; }
        public string DiscrepancyFlagging { get; set; }
        public string PolicyAssessment { get; set; }
        public string EntitlementCalculation { get; set; }
        public string ClaimDecision { get; set; }
        public string OutcomeCommunication { get; set; }
        public string PaymentProcessing { get; set; }
        public string ClaimClosure { get; set; }
        public string ClaimArchiving { get; set; }
    }

    public class ClaimResponseModel
    {
        public int TrackingID { get; set; }
        public string InitialSubmission { get; set; }
        public string InformationGathering { get; set; }
        public string DocumentUploads { get; set; }
        public string EvidenceSubmission { get; set; }
        public string ClaimRegistration { get; set; }
        public string InformationVerification { get; set; }
        public string CrossCheckDetails { get; set; }
        public string DiscrepancyFlagging { get; set; }
        public string PolicyAssessment { get; set; }
        public string EntitlementCalculation { get; set; }
        public string ClaimDecision { get; set; }
        public string OutcomeCommunication { get; set; }
        public string PaymentProcessing { get; set; }
        public string ClaimClosure { get; set; }
        public string ClaimArchiving { get; set; }
    }

    public class ClaimInstructionsModel
    {
        public string Step1 { get; set; }
        public string Step2 { get; set; }
        public string Step3 { get; set; }
        public string Step4 { get; set; }
        public string Step5 { get; set; }
    }
}
