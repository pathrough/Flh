
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------


namespace Flh.Business.Data
{

using System;
    using System.Collections.Generic;
    
public partial class Admin
{

    public Admin()
    {

        this.Classes = new HashSet<Classes>();

        this.Classes1 = new HashSet<Classes>();

        this.Trade = new HashSet<Trade>();

        this.Trade1 = new HashSet<Trade>();

        this.Area = new HashSet<Area>();

        this.Area1 = new HashSet<Area>();

    }


    public long uid { get; set; }

    public System.DateTime created { get; set; }

    public bool enabled { get; set; }



    public virtual User User { get; set; }

    public virtual ICollection<Classes> Classes { get; set; }

    public virtual ICollection<Classes> Classes1 { get; set; }

    public virtual ICollection<Trade> Trade { get; set; }

    public virtual ICollection<Trade> Trade1 { get; set; }

    public virtual ICollection<Area> Area { get; set; }

    public virtual ICollection<Area> Area1 { get; set; }

}

}
