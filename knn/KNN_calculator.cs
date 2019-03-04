using System;
using System.Data;
using System.Windows.Forms;

public static class KNN_calculator
{

    /// <summary>
    /// Given a set of points with categories, guess the category for a given point.
    /// </summary>
    /// <param name="dt">Set of points.</param>
    /// <param name="xy">Given point.</param>
    /// <param name="k">Number of neighbours to use.</param>
    /// <param name="weighted">Indicates if the neighbours are wewighted by distance.</param>
    /// <returns>Guessed category.</returns>
    public static string guess(DataTable dt, double xVal, double yVal, int k, bool weighted)
    {
        double x, y; // Point co-ordinates.        
        string category; // Category
        int N = 0; // Number of data points.
        double dist; // Distance between target point and data point.
        double addition;
        DataTable xydists = new DataTable();
        xydists.Columns.Add("x");
        xydists.Columns.Add("y");
        xydists.Columns.Add("Category");
        xydists.Columns.Add(new DataColumn("Distance",typeof(double)));
        double num_a = 0, num_b = 0, num_c = 0;

        foreach (DataRow row in dt.Rows)
        {
            if (row[0] != DBNull.Value && row[1] != DBNull.Value && row[2] != DBNull.Value)
            {
                // Increment count.
                N++;

                // Get values.
                x = Convert.ToDouble(row[0]);
                y = Convert.ToDouble(row[1]);
                category = Convert.ToString(row[2]);

                // Determine distance from target point.
                dist = Math.Pow((yVal - y) * (yVal - y) + (xVal - x) * (xVal - x), .5);

                // Save point.
                xydists.Rows.Add(x, y, category, dist);
            }
        }

        DataView view = xydists.DefaultView;
        view.Sort = "Distance ASC";

        int rownum = 0;
        foreach (DataRow srow in view.ToTable().Rows)
        {
            if (rownum < k)
            {
                x = Convert.ToDouble(srow[0]);
                y = Convert.ToDouble(srow[1]);
                category = Convert.ToString(srow[2]);
                dist = Convert.ToDouble(srow[3]);

                if (weighted)
                { addition = 1 / dist; }
                else
                { addition = 1; }

                if (category == "A") { num_a += addition; }
                else if (category == "B") { num_b += addition; }
                else { num_c += addition; };
            }
            rownum++;
        }

        // Return the category with the max number of neighbours, picking lower letters in case of a tie.
        double max_num = Math.Max(num_a, Math.Max(num_b, num_c));
        string return_guess = "";
        if (num_a == max_num) { return_guess += "A"; };
        if (num_b == max_num) { return_guess += "B"; };
        if (num_c == max_num) { return_guess += "C"; };
        return return_guess;
    }
}
