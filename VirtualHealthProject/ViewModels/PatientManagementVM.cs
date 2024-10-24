using VirtualHealthProject.Models;

namespace VirtualHealthProject.ViewModels
{
    public class PatientManagementVM
    {
        public int patientCount { get; set; }
        public int bedCount { get; set; }
        public int occupiedbedsCount { get; set; }
        public int admissionCount { get; set; }
    }
}
