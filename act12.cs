public class Furniture {
    private float weight;
    private double price;
    private boolean set;
    private String name, material, colour;

    public Furniture() {
        this(0.0, 0.0f, false, "", "", "");
    }

    public Furniture(String name, double price) {
        this(price, 0.0f, false, name, "", "");
    }

    public Furniture(String name, double price, String material) {
        this(price, 0.0f, false, name, material, "");
    }

    public Furniture(String name, double price, String material, String colour) {
        this(price, 0.0f, false, name, material, colour);
    }

    public Furniture(double price, float weight, boolean set, String name, String material, String colour) {
        this.price = price;
        this.weight = weight;
        this.set = set;
        this.name = name;
        this.material = material;
        this.colour = colour;
    }
}
