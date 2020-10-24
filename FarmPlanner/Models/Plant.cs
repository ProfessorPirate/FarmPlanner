using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlanner.Models
{
    class Plant : ValidateBindableBase
    {
        // GUID
        private Guid _guid;
        public Guid guid
        {
            get { return _guid; }
            set { SetProperty(ref _guid, value); }
        }

        // Plant ID
        private int _plantId;
        public int plantId
        {
            get { return _plantId; }
            set { SetProperty(ref _plantId, value); }
        }

        // Plant Name
        private string _plantName;
        public string plantName
        {
            get { return _plantName; }
            set { SetProperty(ref _plantName, value); }
        }

        // Latin Name
        private string _latinName;
        public string latinName
        {
            get { return _latinName; }
            set { SetProperty(ref _latinName, value); }
        }

        // Company ID
        private int _companyId;
        public int companyId
        {
            get { return _companyId; }
            set { SetProperty(ref _companyId, value); }
        }

        // Seeds Per Packet
        private int _seedsPerPacket;
        public int seedsPerPacket
        {
            get { return _seedsPerPacket; }
            set { SetProperty(ref _seedsPerPacket, value); }
        }

        // Planting Depth
        private decimal _plantingDepth;
        private decimal _plantingDepthFeet;
        public decimal plantingDepthFeet
        {
            get { return _plantingDepthFeet; }
            set
            {
                SetProperty(ref _plantingDepthFeet, value);
                SetProperty(ref _plantingDepth, (value * 12) + _plantingDepthInches);
            }
        }
        private decimal _plantingDepthInches;
        public decimal plantingDepthInches
        {
            get { return _plantingDepthInches; }
            set
            {
                SetProperty(ref _plantingDepthInches, value);
                SetProperty(ref _plantingDepth, (_plantingDepthFeet * 12) + value);
            }
        }

        // Plant Spacing
        private decimal _plantSpacing;
        private decimal _plantSpacingFeet;
        public decimal plantSpacingFeet
        {
            get { return _plantSpacingFeet; }
            set
            {
                SetProperty(ref _plantSpacingFeet, value);
                SetProperty(ref _plantSpacing, (value * 12) + _plantSpacingInches);
            }
        }
        private decimal _plantSpacingInches;
        public decimal plantSpacingInches
        {
            get { return _plantSpacingInches; }
            set
            {
                SetProperty(ref _plantSpacingInches, value);
                SetProperty(ref _plantSpacing, (_plantSpacingFeet * 12) + value);
            }
        }

        // Row Spacing
        private decimal _rowSpacing;
        private decimal _rowSpacingFeet;
        public decimal rowSpacingFeet
        {
            get { return _rowSpacingFeet; }
            set
            {
                SetProperty(ref _rowSpacingFeet, value);
                SetProperty(ref _rowSpacing, (value * 12) + _rowSpacingInches);
            }
        }
        private decimal _rowSpacingInches;
        public decimal rowSpacingInches
        {
            get { return _rowSpacingInches; }
            set
            {
                SetProperty(ref _rowSpacingInches, value);
                SetProperty(ref _rowSpacing, (_rowSpacingFeet * 12) + value);
            }
        }

        // Plant Category ID
        private int _plantCategoryId;
        public int plantCategoryId
        {
            get { return _plantCategoryId; }
            set { SetProperty(ref _plantCategoryId, value); }
        }

        // Growth Habit ID
        private int _growthHabitId;
        public int growthHabitId
        {
            get { return _growthHabitId; }
            set { SetProperty(ref _growthHabitId, value); }
        }

        // Germination Rate
        private decimal _germinationRate;
        public decimal germinationRate
        {
            get { return _germinationRate; }
            set { SetProperty(ref _germinationRate, value); }
        }

        // Days to Maturity
        private int _daysToMaturity;
        public int daysToMaturity
        {
            get { return _daysToMaturity; }
            set { SetProperty(ref _daysToMaturity, value); }
        }

        // Days Before Transplant
        private int _daysBeforeTransplant;
        public int daysBeforeTransplant
        {
            get { return _daysBeforeTransplant; }
            set { SetProperty(ref _daysBeforeTransplant, value); }
        }

        // Tolerates Pollution
        private bool _toleratesPollution;
        public bool toleratesPollution
        {
            get { return _toleratesPollution; }
            set { SetProperty(ref _toleratesPollution, value); }
        }

        // Frost Tender
        private bool _frostTender;
        public bool frostTender
        {
            get { return _frostTender; }
            set { SetProperty(ref _frostTender, value); }
        }

        // Flower Type ID
        private int _flowerTypeId;
        public int flowerTypeId
        {
            get { return _flowerTypeId; }
            set { SetProperty(ref _flowerTypeId, value); }
        }
    }
}
