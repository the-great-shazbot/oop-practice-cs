using System;

class BeverageItem : VendableItem
{

    private bool is_liquid = true;
    private string catalog_code;

    public BeverageItem (string name, double price, string code) : base (name, price)
    {
        CatalogCode = code;
    }

    public override string CatalogCode
    {
        get { return this.catalog_code; }
        set
        {
            if (value[0] != 'B')
            {
                throw new ArgumentException ("All beverage items must begin their code with `B`");
            }
            else
            {
                this.catalog_code = value;
            }
        }
    }
}