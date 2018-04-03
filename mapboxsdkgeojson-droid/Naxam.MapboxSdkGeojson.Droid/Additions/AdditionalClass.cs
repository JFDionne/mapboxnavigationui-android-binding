﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using GoogleGson;
using Java.Lang.Reflect;


namespace Com.Mapbox.Geojson.Gson
{
    public partial class BoundingBoxDeserializer
    {
        public Java.Lang.Object Deserialize(JsonElement p0, IType p1, IJsonDeserializationContext p2)
        {
            return GeojsonDeserialize(p0, p1, p2);
        }

    }

    public partial class GeometryDeserializer
    {
        public Java.Lang.Object Deserialize(JsonElement p0, IType p1, IJsonDeserializationContext p2)
        {
            var result = GeometryDeserialize(p0, p1, p2);

            return Android.Runtime.Extensions.JavaCast<Java.Lang.Object>(result);
        }

    }

    public partial class PointDeserializer
    {
        public Java.Lang.Object Deserialize(JsonElement p0, IType p1, IJsonDeserializationContext p2)
        {
            return PointDeserialize(p0, p1, p2);
        }

    }

    public partial class BoundingBoxSerializer
    {
        public JsonElement Serialize(Java.Lang.Object p0, IType p1, IJsonSerializationContext p2)
        {

            return Serialize((Com.Mapbox.Geojson.BoundingBox)p0, p1, p2);
        }

    }

    public partial class PointSerializer
    {
        public JsonElement Serialize(Java.Lang.Object p0, IType p1, IJsonSerializationContext p2)
        {
            return Serialize((Com.Mapbox.Geojson.Point)p0, p1, p2);
        }
    }


}

namespace Com.Mapbox.Geojson.Gson
{
    partial class GeometryTypeAdapter
    {
        public override unsafe Java.Lang.Object Read(global::GoogleGson.Stream.JsonReader p0)
        {
            return Android.Runtime.Extensions.JavaCast<Java.Lang.Object>(ReadGeometry(p0));
        }

        public override unsafe void Write(global::GoogleGson.Stream.JsonWriter p0, Java.Lang.Object p1)
        {
            Write(p0, p1 as Com.Mapbox.Geojson.IGeometry);
        }
    }
}

namespace Com.Mapbox.Geojson {


    abstract partial class MultiLineString : ICoordinateContainer
    {
        Java.Lang.Object ICoordinateContainer.Coordinates()
        {
            var coords = Coordinates().ToArray();
            var jlist = Android.Runtime.JavaList.FromArray(coords);

            return jlist;
        }
    }

	partial class LineString : ICoordinateContainer
    {
        Java.Lang.Object ICoordinateContainer.Coordinates()
        {
            var coords = Coordinates().ToArray();
            var jlist = Android.Runtime.JavaList.FromArray(coords);

            return jlist;
        }
	}

	partial class MultiPoint : ICoordinateContainer
    {
        Java.Lang.Object ICoordinateContainer.Coordinates()
        {
            var coords = Coordinates().ToArray();
            var jlist = Android.Runtime.JavaList.FromArray(coords);

            return jlist;
        }
	}

	partial class Polygon : ICoordinateContainer
    {
        Java.Lang.Object ICoordinateContainer.Coordinates()
        {
            var coords = Coordinates().ToArray();
            var jlist = Android.Runtime.JavaList.FromArray(coords);

            return jlist;
        }
	}

	partial class MultiPolygon : ICoordinateContainer
    {
        Java.Lang.Object ICoordinateContainer.Coordinates()
        {
            var coords = Coordinates().ToArray();
            var jlist = Android.Runtime.JavaList.FromArray(coords);

            return jlist;
        }
	}

	partial class Point : ICoordinateContainer
    {
        Java.Lang.Object ICoordinateContainer.Coordinates()
        {
            var coords = Coordinates().ToArray();
            var jlist = Android.Runtime.JavaList.FromArray(coords);

            return jlist;
        }
    }
}