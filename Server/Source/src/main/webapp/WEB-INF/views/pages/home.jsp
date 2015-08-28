<html>
    <header>
        <title>Home Page</title>
    </header>
    <body>
        <div class="wrapper">
            <jsp:include page="/WEB-INF/layouts/default/header.jsp" />
            <div class="container">
                <h1>Home page</h1>
                <div class="row">
                    <div class="col-md-4">
                        Test Bootstrap
                    </div>
                    <div class="col-md-8">
                        Test Bootstrap
                    </div>
                </div>
                <a href="javascript:void(0)" onclick="test()">Test JS</a>
            </div>
            <jsp:include page="/WEB-INF/layouts/default/footer.jsp" />

            <%--include script--%>
            <script language="JavaScript" src="/resources/js/frontend/home.js"></script>
        </div>
    </body>
</html>