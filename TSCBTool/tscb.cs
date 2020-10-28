using System;
using System.IO;
using System.Collections.Generic;
using Dicom.IO;

public class tscbheader
{
    string magic; // TSCB
    uint version; // 0A 00 00 00
    uint unknown1; // Always 00 00 00 01
    uint filetable; // Offset to tile filenames
    float worldscale; // Scale value for the X and Z axes for the world.
    float vscale; // Scale value for the Y axis.
    uint materialcount; // Number of material entries.
    uint terraincount; // Number of terrain entries.
    uint padding1; // Padding.
    uint padding2; // Padding.
    float tilescale; // Scale value for the X and Z axes for individual terrains.
    uint unknown2; // Always 00 00 00 08

    public tscbheader(string magic, uint version, uint unknown1, uint filetable, float worldscale, float vscale, uint materialcount, uint terraincount, uint padding1, uint padding2, float tilescale, uint unknown2)
    {
        this.magic = magic;
        this.version = version;
        this.unknown1 = unknown1;
        this.filetable = filetable;
        this.worldscale = worldscale;
        this.vscale = vscale;
        this.materialcount = materialcount;
        this.terraincount = terraincount;
        this.padding1 = padding1;
        this.padding2 = padding2;
        this.tilescale = tilescale;
        this.unknown2 = unknown2;
    }

    public string Magic { get { return magic; } set { magic = value; } }
    public uint Version { get { return version; } set { version = value; } }
    public uint Unknown1 { get { return unknown1; } set { unknown1 = value; } }
    public uint FileTable { get { return filetable; } set { filetable = value; } }
    public float WorldScale { get { return worldscale; } set { worldscale = value; } }
    public float Vscale { get { return vscale; } set { vscale = value; } }
    public uint MaterialCount { get { return materialcount; } set { materialcount = value; } }
    public uint TerrainCount { get { return terraincount; } set { terraincount = value; } }
    public uint Padding1 { get { return padding1; } set { padding1 = value; } }
    public uint Padding2 { get { return padding2; } set { padding2 = value; } }
    public float TileScale { get { return tilescale; } set { tilescale = value; } }
    public uint Unknown2 { get { return unknown2; } set { unknown2 = value; } }
}

public class tscbentry
{
    // Private values for the entries.
    uint index;
    float u;
    float v;
    float un1;
    float un2;
    uint uni1;
    uint uni2;
    uint uni3;
    float x;
    float y;
    float area_size;
    float mint;
    float maxt;
    float minw;
    float maxw;
    uint filename;
    string file;
    bool water;
    bool grass;

    /// <summary>
    /// Creates a material entry for the tscb.
    /// </summary>
    /// <param name="index">The index of this material definition.</param>
    /// <param name="u">U value of the UV.</param>
    /// <param name="v">V value of the UV.</param>
    /// <param name="un1">Unknown value 1, 0-1 values in vanilla.</param>
    /// <param name="un2">Unknown value 2, 0.2-1.63 values in vanilla.</param>
    public tscbentry(uint index, float u, float v, float un1, float un2)
    {
        this.index = index;
        this.u = u;
        this.v = v;
        this.un1 = un1;
        this.un2 = un2;
    }

    /// <summary>
    /// Creates a terrain entry for the tscb.
    /// </summary>
    /// <param name="x">X position.</param>
    /// <param name="y">Y position.</param>
    /// <param name="area_size">Scale of the tile.</param>
    /// <param name="mint">Minimum terrain render height, ranges 0-1.</param>
    /// <param name="maxt">Maximum terrain render height, ranges 0-1.</param>
    /// <param name="minw">Minimum water render height, ranges 0-1.</param>
    /// <param name="maxw">Maximum water render height, ranges 0-1.</param>
    /// <param name="un1">Unknown value, usually 0, 1, or 2. Crashes on 4 or 16.</param>
    /// <param name="filename">Relative offset to the filename string.</param>
    /// <param name="un2">Unknown, usually 0.</param>
    /// <param name="un3">Unknown, usually 0.</param>
    /// <param name="water">Does this cell have water?</param>
    /// <param name="grass">Does this cell have grass?</param>
    public tscbentry(float x, float y, float area_size, float mint, float maxt, float minw, float maxw, uint uni1, uint filename, string file, uint uni2, uint uni3, bool water, bool grass)
    {
        this.x = x;
        this.y = y;
        this.area_size = area_size;
        this.mint = mint;
        this.maxt = maxt;
        this.minw = minw;
        this.maxw = maxw;
        this.uni1 = uni1;
        this.filename = filename;
        this.file = file;
        this.uni2 = uni2;
        this.uni3 = uni3;
        this.water = water;
        this.grass = grass;

    }

    // Getters and setters for values in the entries.
    public uint Index { get { return index; } set { index = value; } }
    public float U { get { return u; } set { u = value; } }
    public float V { get { return v; } set { v = value; } }
    public float Un1 { get { return un1; } set { un1 = value; } }
    public float Un2 { get { return un2; } set { un2 = value; } }
    public uint Uni1 { get { return uni1; } set { uni1 = value; } }
    public uint Uni2 { get { return uni2; } set { uni2 = value; } }
    public uint Uni3 { get { return uni3; } set { uni3 = value; } }
    public float X { get { return x; } set { x = value; } }
    public float Y { get { return y; } set { y = value; } }
    public float Area_Size { get { return area_size; } set { area_size = value; } }
    public float Mint { get { return mint; } set { mint = value; } }
    public float Maxt { get { return maxt; } set { maxt = value; } }
    public float Minw { get { return minw; } set { minw = value; } }
    public float Maxw { get { return maxw; } set { maxw = value; } }
    public uint Filename { get { return filename; } set { filename = value; } }
    public string File { get { return file; } set { file = value; } }
    public bool Water { get { return water; } set { water = value; } }
    public bool Grass { get { return grass; } set { grass = value; } }
}

public class tscbreader
{
    // Create private lists for the material and terrain entries.
    tscbheader header = new tscbheader("", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
    List<tscbentry> materials = new List<tscbentry>();
    List<tscbentry> terrain = new List<tscbentry>();

    public tscbreader(string fname)
    {
        // Open TSCB file and begin reading data into lists.
        using (var r = new EndianBinaryReader(File.OpenRead(fname), Endian.Big))
        {
            // Create iterator variable.
            int i = 0;

            // Read header.
            header.Magic = new string(r.ReadChars(4));
            header.Version = r.ReadUInt32();
            header.Unknown1 = r.ReadUInt32();
            header.FileTable = r.ReadUInt32();
            header.WorldScale = r.ReadSingle();
            header.Vscale = r.ReadSingle();
            header.MaterialCount = r.ReadUInt32();
            header.TerrainCount = r.ReadUInt32();
            header.Padding1 = r.ReadUInt32();
            header.Padding2 = r.ReadUInt32();
            header.TileScale = r.ReadSingle();
            header.Unknown2 = r.ReadUInt32();

            // Material count info. Not used by the program.
            uint matbsize = r.ReadUInt32();

            // Offsets to materials. Not used by the program.
            List<uint> moffs = new List<uint>();
            while (i < header.MaterialCount)
            {
                moffs.Add(r.ReadUInt32());
                i += 1;
            }

            // Read material definitions.
            i = 0;
            while (i < header.MaterialCount)
            {
                materials.Add(new tscbentry(r.ReadUInt32(), r.ReadSingle(), r.ReadSingle(), r.ReadSingle(), r.ReadSingle()));
                i += 1;
            }

            // Terrain count info.
            uint numter = header.TerrainCount;
            i = 0;

            // Offsets to terrains. Not used by the program.
            List<uint> toffs = new List<uint>();
            while (i < numter)
            {
                toffs.Add(r.ReadUInt32());
                i += 1;
            }

            // Read terrain definitions.
            i = 0;
            while (i < numter)
            {
                terrain.Add(new tscbentry(r.ReadSingle(), r.ReadSingle(), r.ReadSingle(), r.ReadSingle(), r.ReadSingle(), r.ReadSingle(), r.ReadSingle(), r.ReadUInt32(), r.ReadUInt32(), "", r.ReadUInt32(), r.ReadUInt32(), false, false));
                if (r.ReadUInt32() == 4)
                {
                    if (r.ReadUInt32() == 8)
                    {
                        r.ReadBytes(36);
                        terrain[i].Water = true;
                        terrain[i].Grass = true;
                    }
                    else
                    {
                        byte[] b = r.ReadBytes(16);
                        if ((int)b[1] == 0)
                        {
                            terrain[i].Grass = true;
                        }
                        else
                        {
                            terrain[i].Water = true;
                        }
                    }
                }
                i += 1;
            }

            // Read filenames into created terrain data.
            i = 0;
            while (i < numter)
            {
                terrain[i].File = new string(r.ReadChars(10));
                r.ReadBytes(2);
                i += 1;
            }
            r.Close();
            moffs.Clear();
            toffs.Clear();
        }
    }

    // Getters and setters for the materials and terrain lists.
    public List<tscbentry> Materials
    {
        get { return materials; }
        set { materials = value; }
    }
    public List<tscbentry> Terrain
    {
        get { return terrain; }
        set { terrain = value; }
    }
    public tscbheader Header
    {
        get { return header; }
        set { header = value; }
    }
}

public class tscbwriter
{
    public tscbwriter(string fname, tscbheader header, List<tscbentry> materials, List<tscbentry> terrain)
    {
        // Open TSCB file and begin writing data to it.
        using (var w = new EndianBinaryWriter(File.Open(fname, FileMode.Create), Endian.Big))
        {
            // Create iterator variable.
            int i = 0;

            // Write header.
            w.Write(header.Magic.ToCharArray());
            w.Write(header.Version);
            w.Write(header.Unknown1);
            w.Write(header.FileTable);
            w.Write(header.WorldScale);
            w.Write(header.Vscale);
            w.Write(header.MaterialCount);
            w.Write(header.TerrainCount);
            w.Write(header.Padding1);
            w.Write(header.Padding2);
            w.Write(header.TileScale);
            w.Write(header.Unknown2);

            // Write material offsets.
            w.Write((header.MaterialCount * 24) + 4);
            while (i < header.MaterialCount)
            {
                w.Write(Convert.ToUInt32(header.MaterialCount * 4 + (i * 16)));
                i += 1;
            }

            // Write material definitions.
            i = 0;
            while (i < header.MaterialCount)
            {
                w.Write(materials[i].Index);
                w.Write(materials[i].U);
                w.Write(materials[i].V);
                w.Write(materials[i].Un1);
                w.Write(materials[i].Un2);
                i += 1;
            }

            // Calculate size of terrain tiles.
            i = 0;
            List<uint> tsz = new List<uint>();
            uint tszt = 0;
            while (i < header.TerrainCount)
            {
                if ((terrain[i].Water == true) & (terrain[i].Grass == true))
                { tsz.Add(84); }
                else if ((terrain[i].Water == true) ^ (terrain[i].Grass == true))
                { tsz.Add(64); }
                else
                { tsz.Add(44); }
                w.Write((header.TerrainCount * 4) + tszt);
                tszt += tsz[i];
                i += 1;
            }

            // Write terrain tiles.
            i = 0;
            uint sub = 0;
            while (i < header.TerrainCount)
            {
                w.Write(terrain[i].X);
                w.Write(terrain[i].Y);
                w.Write(terrain[i].Area_Size);
                w.Write(terrain[i].Mint);
                w.Write(terrain[i].Maxt);
                w.Write(terrain[i].Minw);
                w.Write(terrain[i].Maxw);
                w.Write(terrain[i].Uni1);
                w.Write(Convert.ToUInt32(tszt + (header.TerrainCount * 4) - sub + (i * 8) - 32)); // Calculate offset to filename string.
                w.Write(terrain[i].Uni2);
                w.Write(terrain[i].Uni3);
                if (terrain[i].Water && terrain[i].Grass == true)
                {
                    var vals = new uint[] { 4, 8, 20, 3, 1, 1, 0, 3, 0, 1, 0 };
                    foreach (uint v in vals) { w.Write(v); }
                }
                else if (terrain[i].Water == true)
                {
                    var vals = new uint[] { 4, 4, 3, 1, 1, 0 };
                    foreach (uint v in vals) { w.Write(v); }
                }
                else if (terrain[i].Grass == true)
                {
                    var vals = new uint[] { 4, 4, 3, 0, 1, 0 };
                    foreach (uint v in vals) { w.Write(v); }
                }
                else
                {
                    w.Write(0);
                }
                sub += tsz[i];
                i += 1;
            }

            // Write filename strings.
            i = 0;
            while (i < header.TerrainCount)
            {
                w.Write(terrain[i].File.ToCharArray());
                w.Write((UInt16)0);
                i += 1;
            }
            w.Close();
        }
    }
}