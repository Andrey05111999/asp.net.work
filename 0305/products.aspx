<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="MainContent">
    <h2>Product List</h2>
    <table id="productTable" class="table table-striped table-bordered">
        <thead>
            <tr>
                <th>Product ID</th>
                <th>Product Name</th>
                <th>Price</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="productRepeater" runat="server" DataSourceID="productListDataSource">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Id") %></td>
                        <td><%# Eval("Name") %></td>
                        <td><%# Eval("Price") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
