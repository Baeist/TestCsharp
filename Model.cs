using System;
using System.ComponentModel.DataAnnotations;

class Model{

    [Range(-1, 100)]
    private int id {get; set;} = -1;
    [Required]
    public string name {get; set;} = "not available";
    [Required]
    private bool isGood {get; set;} = true;

    public Model(int id, string name, bool isGood){

        this.id = id;
        this.name = name;
        this.isGood = isGood;

    }

    public Model(){}

    public void Deconstruct(out int idDeconstruct, out string nameDe, out bool isGoodDe){
        idDeconstruct = id;
        nameDe = name;
        isGoodDe = isGood;
    }

    
    public string GetName(){
        return name;
    }

}