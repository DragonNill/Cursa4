//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PcSborka.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class MotherBoard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MotherBoard()
        {
            this.Computer = new HashSet<Computer>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Socket { get; set; }
        public string TypeMotherBoardMemory { get; set; }
        public string Form_Factor { get; set; }
        public string Сharacteristics { get; set; }
        public double Cost { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Computer> Computer { get; set; }
    }
}