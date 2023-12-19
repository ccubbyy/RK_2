#include <iostream>
#include <string>
#include <algorithm>
#include <list>


class Building
{
    protected:
    std::string name;
    std::string floors;
    public:
    Building(const std::string& name, const std::string& floors) 
    : name(name),floors(floors) { }

    virtual ~Building() { }

    virtual void Info() const {
        std::cout <<  name << ", " << floors << std::endl;
    }
void setFloors(const std::string& plusFloors)
{
    floors = plusFloors;
}
};

class ResBuilding : public Building
{
protected:
    std::string flats;
public:
    ResBuilding(const std::string& name, const std::string& floors, const std::string& flats)
        :Building(name, floors),flats(flats) { }
void Info() const override {
        std::cout << name << ", " << floors << ", " << flats << std::endl;
    }
    void setFlats(const std::string& newFlat)
{
    flats = newFlats;
}
};

class ofBuilding : public Building
{
protected:
    int offices;
public:
    ofBuilding (const std::string& name, const std::string& floors, int offices)
        :Building(name, floors), offices(offices) { }
void Info() const override {
        std::cout << name << ", " << floors << ", " << offices << std::endl;
    }
    void setOffice(int newOffice)
{
    offices = newOffice;
}
};

void modifyBuilding(Building* building)
{
    building->setFloors("New floor");
    building->Info();
}

int main()
{
    std::list<Building*> Building;
    Building.push_back(new ResBuilding("House", "Home", "Flat"));
    Building.push_back(new ofBuilding("Lachta", "Ochta", "smthElse"));

    for (Building* building : Building) {
    modifyBuilding(building);
}

for (Building* building : Building)
{
    delete(building);
}
}
